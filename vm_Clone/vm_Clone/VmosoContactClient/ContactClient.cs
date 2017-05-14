using System;
using System.Collections.Generic;
using VmosoApiClient.Api;
using VmosoApiClient.Client;
using VmosoApiClient.Model;
using log4net;
using System.Drawing;
using Newtonsoft.Json;

namespace VmosoContactClient
{
    public class ContactClient
    {
        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private VmosoSession session;

        public const String INVITE_CONNECTED = "connected";
        public const String INVITE_TRUSTED = "trusted";
        public const String CONTACT_TYPE_ACQUAINTED = "acquainted";

        public ContactClient(VmosoSession session)
        {
            log.Debug("Creating ContactClient for host/userKey " + session.Host + "/" + session.UserKey);
            this.session = session;
        }

        public ContactItem searchUserByEmail(String email)
        {
            try
            {
                log.Debug("Searching email " + email);
                UserApi userApi = new UserApi(session.GetApiClient());

                ContactcardApi contactCartApi = new ContactcardApi(session.GetApiClient());
                GetUserByEmailResult result = userApi.GetUserByEmail(email);
                if (result.Hdr.Rc == 0)
                {
                    DisplayRecord displayRecord = result.DisplayRecord;
                    ContactItem contactItem = getContact(displayRecord.Key);
                    contactItem.Key = displayRecord.Key;
                    contactItem.Link = session.OriginalHost + "/c/" + contactItem.Key;
                    return contactItem;
                }
                else
                {
                    throw new Exception("Email " + email + " not found");
                }
            } catch (Exception ex)
            {
                throw new Exception("Email searching email " + email, ex);
            }
        }

        public void inviteEmailAddress(ContactItem contact, String type)
        {
            try
            {
                ContactApi contactApi = new ContactApi(session.GetApiClient());
                InviteEmailAddressInput input = new InviteEmailAddressInput(type, true, contact.Email, "Invitation message");
                InviteEmailAddressResult result = contactApi.InviteEmailAddress(input);
                if (result.Hdr.Rc != 0)
                {
                    throw new Exception("Error while inviting email address");
                }
            } catch (Exception ex)
            {
                throw new Exception("Error while inviting email address", ex);
            }
        }

        public void inviteContact(ContactItem contact, String invitationMessage, String type)
        {
            try
            {
                ContactApi contactApi = new ContactApi(session.GetApiClient());
                List<String> contactKeys = new List<String>();
                contactKeys.Add(contact.Key);
                InviteUsersInput input = new InviteUsersInput(type,null,invitationMessage, contactKeys);
                InviteUsersResult result = contactApi.InviteUsers(input);
                if (result.Hdr.Rc != 0)
                {
                    throw new Exception("Error while inviting contact key " + contact.Key);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error while inviting contactkey " + contact.Key, ex);
            }
        }

        public ContactItem importContact(ContactItem contactItem)
        {
            try
            {
                ContactApi contactApi = new ContactApi(session.GetApiClient());
                List<ImportUserRecord> users = new List<ImportUserRecord>();
                ImportUserRecord user = new ImportUserRecord();
                user.FirstName = contactItem.Name;
                user.Email = contactItem.Email;
                user.Phone = contactItem.Phone;
                users.Add(user);

                ImportAcquaintancesInput input = new ImportAcquaintancesInput(users);
                ImportAcquaintancesResult result = contactApi.ImportAcquaintances(input);
                if (result.Hdr.Rc == 0)
                {
                    List<ImportUserRecord> failedUsers = result.FailedUsers;
                    if (failedUsers.Count > 0)
                    {
                        throw new Exception("Error importing user");
                    }
                    else
                    {
                        return searchUserByEmail(contactItem.Email);
                    }
                }
                else
                {
                    throw new Exception("Error importing contact");
                }
            } catch (Exception ex)
            {
                throw new Exception("Error importing contact", ex);
            }

        }
        public void deleteContact(ContactItem contactItem)
        {
            try
            {
                ContactApi contactApi = new ContactApi(session.GetApiClient());
                List<String> keys = new List<String>();
                keys.Add(contactItem.Key);
                DeleteContactsInput input = new DeleteContactsInput(keys);
                DeleteContactsResult result = contactApi.DeleteContacts(input);
                if (result.Hdr.Rc == 0)
                {
                    /*List<String> failedUsers = result.FailedUsers;
                    if(failedUsers.Count > 0 )
                    {
                        throw new Exception("Error deleting contact");
                    }*/
                }
                else
                {
                    throw new Exception("Error deleting contact");
                }
            } catch (Exception ex)
            {
                throw new Exception("Error deleting contact",ex);
            }

        }

        public ContactItem getContact(String contactKey)
        {
            try { 
                ContactApi contactApi = new ContactApi(session.GetApiClient());
                GetProfileResult result = contactApi.GetProfile(contactKey);
                
                if (result.Hdr.Rc == 0)
                {
                    ProfileRecord record = result.ProfileRecord;
                    ContactItem contactItem = new ContactItem();
                    contactItem.Name = record.DisplayName;
                    contactItem.Email = record.Email;
                    contactItem.Phone = record.Phone;
                    contactItem.Key = record.UserKey;
                    contactItem.IconKey = record.IconSmall;
                    contactItem.ProfileRecord = record;
                    return contactItem;
                }
                else
                {
                    throw new Exception("Error getting contact");
                }
            } catch (Exception ex)
            {
                        throw new Exception("Error getting contact", ex);
            }
        }
    }
}
