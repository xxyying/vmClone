using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;
using vm_Clone;

namespace vm_Clone
{
  public class CountIcon
  {
    private static readonly Size pixelNumSize = new Size(4, 5);

    public static Image GetImage(string text, Size size)
    {
      Bitmap bitmap = new Bitmap(size.Width, size.Height);
      Graphics graphics = Graphics.FromImage(bitmap);
      graphics.Clear(Color.White);

      int circleRadius = bitmap.Width > bitmap.Height ? bitmap.Height : bitmap.Width;
      Size circleSize = new Size(circleRadius, circleRadius);
      float fontSize = size.Width > size.Height ? size.Width : size.Height;
      string fontFamily = "Arial";
      FontStyle fontStyle = FontStyle.Bold;

      System.Drawing.Font drawFont = new System.Drawing.Font(fontFamily, fontSize, fontStyle);
      System.Drawing.SolidBrush drawEllipseBrush = new System.Drawing.SolidBrush(ColorTranslator.FromHtml("#279ace"));
      System.Drawing.SolidBrush drawCountBrush = new System.Drawing.SolidBrush(System.Drawing.Color.White);

      graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

      float height = graphics.MeasureString(text, drawFont).Height;

      while (height >= circleSize.Height)
      {
        drawFont = new System.Drawing.Font(fontFamily, drawFont.Size - 0.01f, fontStyle);
        height = graphics.MeasureString(text, drawFont).Height;
      }

      double radius = Math.Sqrt(circleSize.Width * 0.5 * circleSize.Width * 0.5 - height * 0.5 * height * 0.5);

      while (radius * 2 < graphics.MeasureString(text, drawFont).Width)
      {
        drawFont = new System.Drawing.Font(fontFamily, drawFont.Size - 0.01f, fontStyle);
        height = graphics.MeasureString(text, drawFont).Height;
        radius = Math.Sqrt(circleSize.Width * 0.5 * circleSize.Width * 0.5 - height * height * 0.25);
      }

      float ratioOfEllipseToBitmap = 1f;
      SizeF ellipseSize = new SizeF(bitmap.Width * ratioOfEllipseToBitmap, bitmap.Width * ratioOfEllipseToBitmap);
      PointF ellipseLocation = new PointF((float)((bitmap.Width - ellipseSize.Width) * 0.5), (float)((bitmap.Height - ellipseSize.Height) * 0.5));

      RectangleF ellipseRectangle = new RectangleF(ellipseLocation, ellipseSize);

      graphics.FillEllipse(drawEllipseBrush, ellipseRectangle);

      StringFormat stringFormat = new StringFormat();
      stringFormat.Alignment = StringAlignment.Center;
      stringFormat.LineAlignment = StringAlignment.Center;
      
      PointF textPoint = new PointF((float)(ellipseLocation.X + ellipseSize.Width * 0.5 - radius), (float)(ellipseLocation.Y + ellipseSize.Height * 0.5 - height * 0.5));
      SizeF textSize = new SizeF((float)(radius * 2), height);
      RectangleF textRectangle = new RectangleF(textPoint, textSize);

      graphics.DrawString(text, drawFont, drawCountBrush, textRectangle, stringFormat);

      MemoryStream mStream = new MemoryStream();
      bitmap.Save(mStream, ImageFormat.Png);

      Image image = Image.FromStream(mStream);

      drawFont.Dispose();
      drawEllipseBrush.Dispose();
      drawCountBrush.Dispose();
      graphics.Dispose();
      bitmap.Dispose();

      return image;
    }

    public static Icon GetIcon(string text, string originalIcon)
    {
      Size bitmapSize = new Size(32, 32);
      float fontSize = 20;
      string fontFamily = "Arial";
      FontStyle fontStyle = FontStyle.Bold;
      float offset = 0;

      Bitmap bitmap = new Bitmap(bitmapSize.Width, bitmapSize.Height);

      System.Drawing.Font drawFont = new System.Drawing.Font(fontFamily, fontSize, fontStyle);
      System.Drawing.SolidBrush drawEllipseBrush = new System.Drawing.SolidBrush(ColorTranslator.FromHtml("#ffba09"));

      System.Drawing.SolidBrush drawCountBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);

      System.Drawing.Graphics graphics = System.Drawing.Graphics.FromImage(bitmap);

      graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

      if (!string.IsNullOrEmpty(originalIcon))
        graphics.DrawIcon(new Icon(originalIcon), 0, 0);

      float ratioOfEllipseToBitmap = 0.8f;
      SizeF ellipseSize = new SizeF(bitmap.Width * ratioOfEllipseToBitmap, bitmap.Width * ratioOfEllipseToBitmap);
      PointF ellipseLocation = new PointF(bitmap.Width - ellipseSize.Width, 0);

      RectangleF ellipseRectangle = new RectangleF(ellipseLocation, ellipseSize);

      graphics.FillEllipse(drawEllipseBrush, ellipseRectangle);

      int[,] pixelOne = PixelNumbers.pixelOne;

      int xOffset = (int)ellipseLocation.X + (int)(ellipseSize.Width / 2) - 2;
      int yOffset = (int)ellipseLocation.Y + (int)(ellipseSize.Height / 2) - 2;

      for (int i = 0; i < pixelOne.GetLength(0); i++)
      {
        bitmap.SetPixel(pixelOne[i, 0] + xOffset, pixelOne[i, 1] + yOffset, Color.Black);
      }

      float height = graphics.MeasureString(text, drawFont).Height;

      while (height >= ellipseSize.Height)
      {
        drawFont = new System.Drawing.Font(fontFamily, drawFont.Size - 0.01f, fontStyle);
        height = graphics.MeasureString(text, drawFont).Height;
      }

      double halfLength = Math.Sqrt(ellipseSize.Width * 0.5 * ellipseSize.Width * 0.5 - height * 0.5 * height * 0.5);

      while (halfLength * 2 < graphics.MeasureString(text, drawFont).Width)
      {
        drawFont = new System.Drawing.Font(fontFamily, drawFont.Size - 0.01f, fontStyle);
        height = graphics.MeasureString(text, drawFont).Height;
        halfLength = Math.Sqrt(ellipseSize.Width * 0.5 * ellipseSize.Width * 0.5 - height * height * 0.25);
      }

      StringFormat stringFormat = new StringFormat();
      stringFormat.Alignment = StringAlignment.Center;
      stringFormat.LineAlignment = StringAlignment.Center;

      RectangleF textRectangle = new RectangleF((float)(bitmapSize.Width - ellipseSize.Width * 0.5 - halfLength), (float)(ellipseSize.Height * 0.5 - height * 0.5), (float)(2 * halfLength), height + offset);

      Icon createdIcon = Icon.FromHandle(bitmap.GetHicon());

      drawFont.Dispose();
      drawEllipseBrush.Dispose();
      drawCountBrush.Dispose();
      graphics.Dispose();
      bitmap.Dispose();

      return createdIcon;
    }

     public static Icon CreateTaskTrayIcon(int count, Icon originalIcon)
    {
      Icon numIcon = CreateTaskTrayNumberIcon(count);
      
      //16 is minimum size
      Size iconSize = new Size(16, 16);
      int castOffset = 0;
      Bitmap bitmap = new Bitmap(iconSize.Width, iconSize.Height);
      Graphics graphics = Graphics.FromImage(bitmap);
      
      graphics.Clear(Color.Transparent);
      graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;

      graphics.DrawIcon(originalIcon, 0, 0);

      if (count < 1)
        return Icon.FromHandle(bitmap.GetHicon());

      SolidBrush ellipseBrush = new SolidBrush(ColorTranslator.FromHtml("#FF6633"));

      float diameter = (float)Math.Sqrt(numIcon.Width * numIcon.Width + numIcon.Height * numIcon.Height) + castOffset;

      if (count > 99)
        diameter = (float)Math.Sqrt(pixelNumSize.Width * pixelNumSize.Width * 4 + numIcon.Height * numIcon.Height) + castOffset;

      if (diameter > bitmap.Width)
      {
        return Icon.FromHandle(bitmap.GetHicon());
      }

      SizeF ellipseSize = new SizeF(diameter, diameter);
      PointF ellipseLocation = new PointF(0, 0);

      int ellipseSizeOffset = 1;
      ellipseSize.Width -= ellipseSizeOffset;
      ellipseSize.Height -= ellipseSizeOffset;
      RectangleF ellipseRectangle = new RectangleF(ellipseLocation, ellipseSize);

      graphics.FillEllipse(ellipseBrush, ellipseRectangle);

      int numIconX = (int)(ellipseLocation.X + ellipseSize.Width / 2 - numIcon.Width / 2);

      if (Math.Abs(ellipseLocation.X + ellipseSize.Width / 2 - numIcon.Width / 2) - numIconX >= 0.5)
        numIconX += castOffset;

      int numIconY = (int)(ellipseLocation.Y + ellipseSize.Height - ellipseSize.Height / 2 - numIcon.Height / 2);

      if (Math.Abs((ellipseLocation.Y + ellipseSize.Height - ellipseSize.Height / 2 - numIcon.Height / 2) - numIconY) >= 0.5)
        numIconY += castOffset;


      graphics.DrawIcon(numIcon, numIconX, numIconY);

      ellipseBrush.Dispose();

      return Icon.FromHandle(bitmap.GetHicon());

    }

    private static Icon CreateTaskTrayNumberIcon(int count)
    {
      int xOffset = 1;

      string countStr = count.ToString();
      char[] countCharArray = countStr.ToCharArray();
      int countLength = countCharArray.Length;

      if (countLength > 2)
      {
        countLength = 3;
        xOffset = 0;
      }

      Size IconSize = countLength < 2 ? new Size(pixelNumSize.Width * 2 + (countLength - 1) * xOffset, pixelNumSize.Height) : new Size(pixelNumSize.Width * countLength + (countLength - 1) * xOffset, pixelNumSize.Height);
      
      Bitmap bitmap = new Bitmap(IconSize.Width, IconSize.Height);
      Graphics graphics = Graphics.FromImage(bitmap);
      Color numColor = Color.White;

      for (int i = 0, step = 0; i < countLength; i++, step += pixelNumSize.Width + xOffset)
      {
        int[,] pixelNum = new int[,] { };

        if (countLength == 3)
        {
          if (i == 2)
            pixelNum = PixelNumbers.pixelPlus;
          else
            pixelNum = PixelNumbers.pixelNine;
        }
        else
        {
          pixelNum = TransferCountToPoint((int)char.GetNumericValue(countCharArray[i]));
        }

        if (countLength == 1)
          step = (int)((bitmap.Width - pixelNumSize.Width) / 2);

        for (int j = 0; j < pixelNum.GetLength(0); j++)
        {
          bitmap.SetPixel(pixelNum[j, 0] + step, pixelNum[j, 1], numColor);
        }
      }

      Icon numIcon = Icon.FromHandle(bitmap.GetHicon());

      return numIcon;
    }

    private static int[,] TransferCountToPoint(int count)
    {
      switch (count)
      {
        case 0:
          return PixelNumbers.pixelZero;
        case 1:
          return PixelNumbers.pixelOne;
        case 2:
          return PixelNumbers.pixelTwo;
        case 3:
          return PixelNumbers.pixelThree;
        case 4:
          return PixelNumbers.pixelFour;
        case 5:
          return PixelNumbers.pixelFive;
        case 6:
          return PixelNumbers.pixelSix;
        case 7:
          return PixelNumbers.pixelSeven;
        case 8:
          return PixelNumbers.pixelEight;
        case 9:
          return PixelNumbers.pixelNine;
        default:
          return PixelNumbers.pixelZero;
      }
    }

    private static Image CreateUnreadCountNumberImage(int count)
    {

      Size pixelNumSize = new Size(4, 5);
      int xOffset = 1;

      string countStr = count.ToString();
      char[] countCharArray = countStr.ToCharArray();
      int countLength = countCharArray.Length;

      if (countLength > 2)
        countLength = 3;

      Size IconSize = new Size(pixelNumSize.Width * countLength + (countLength - 1) * xOffset, pixelNumSize.Height);
      Bitmap bitmap = new Bitmap(IconSize.Width, IconSize.Height);
      Graphics graphics = Graphics.FromImage(bitmap);
      Color numColor = Color.White;

      for (int i = 0, step = 0; i < countLength; i++, step += pixelNumSize.Width + xOffset)
      {
        int[,] pixelNum = new int[,] { };

        if (countLength == 3)
        {
          if (i == 2)
            pixelNum = PixelNumbers.pixelPlus;
          else
            pixelNum = PixelNumbers.pixelNine;
        }
        else
        {
          pixelNum = TransferCountToPoint((int)char.GetNumericValue(countCharArray[i]));
        }

        for (int j = 0; j < pixelNum.GetLength(0); j++)
        {
          bitmap.SetPixel(pixelNum[j, 0] + step, pixelNum[j, 1], numColor);
        }
      }

      MemoryStream mStream = new MemoryStream();
      bitmap.Save(mStream, ImageFormat.Png);


      return Image.FromStream(mStream);

    }

    public static Image CreateUnreadCountImage(int count, Size size)
    {
      Image countImage = CreateUnreadCountNumberImage(count);
      Size imageSize = size;

      Bitmap bitmap = new Bitmap(imageSize.Width, imageSize.Height);
      Graphics graphics = Graphics.FromImage(bitmap);

      graphics.Clear(Color.Transparent);
      graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;

      if (count < 1 )
        return Image.FromHbitmap(bitmap.GetHbitmap());

      SolidBrush ellipseBrush = new SolidBrush(ColorTranslator.FromHtml("#279ace"));

      Point countLocation = new Point((int)(bitmap.Width * 0.5 - countImage.Width * 0.5), (int)(bitmap.Height * 0.5 - countImage.Height * 0.5));

      float ellipseYOffset = countImage.Height / 2;
      SizeF ellipseSize = new SizeF(size.Width, countImage.Height + ellipseYOffset * 2 );
      PointF ellipseLocation = new PointF(0, countLocation.Y - ellipseYOffset);
      RectangleF ellipseRectangle = new RectangleF(ellipseLocation, ellipseSize);

      graphics.FillEllipse(ellipseBrush, ellipseRectangle);
      graphics.DrawImage(countImage, countLocation.X, countLocation.Y);

      MemoryStream mStream = new MemoryStream();
      bitmap.Save(mStream, ImageFormat.Png);

      return Image.FromStream(mStream);
    }
  }
}
