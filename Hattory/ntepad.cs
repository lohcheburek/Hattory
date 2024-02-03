﻿using System;
using System.IO;
using Cosmos.System.Graphics;
using System.Drawing;
using ConsoleKeyy = Cosmos.System.ConsoleKeyEx;
using sus = Cosmos.System;
using Cosmos.HAL.BlockDevice;
using System.Linq;
using System.Text.RegularExpressions;
using Cosmos.System.Graphics.Fonts;
using kalavaypravlenie;
using static System.Net.Mime.MediaTypeNames;
using System.Runtime.CompilerServices;
#pragma warning disable CA1416 // Проверка совместимости платформы

namespace Notepad
{
    internal class ntepad
    {
        public static Canvas canvas = Hattory.Kernel.canvas;
        public static string path = @"0:\";
        public static string fileeepath = "";
        public static string txta = "";
        public static string filename = "test.txt";
        public static byte[] bite;
        public static sus.Graphics.Bitmap image;
        public static int iznyy;
        public static int iznai;
        public static string filenameeee;
        public static bool isended = true;
        public static bool isendedbmp = true;
        public static bool islock = false;

        public static void enternote()
        {
            canvas.DrawFilledRectangle(Color.Wheat, 10, 60, 270 + path.Length*2, 250);
            txtxtx.FontDrawer.WriteText("File Manager: " + path,30,70,Color.Black);
            try
            {
                var files_list = Directory.GetFiles(path);
                var directory_list = Directory.GetDirectories(path);
                //txtxtx.FontDrawer.WriteText(string.Join('`',directory_list), 15, 90, Color.Black, true);
                //txtxtx.FontDrawer.WriteText(string.Join('`',files_list), 110, 90, Color.Black, true);
                if (Hattory.Kernel.CheackClick(30, 70, 112, 10))
                {
                    //path = @"0:\" ;
                    path = Hattory.Kernel.globaldskcnt.ToString() + @":\";
                }
                iznyy = 90;
                iznai = 90;
                //directories
                foreach (string dir in directory_list)
                {
                    canvas.DrawFilledRectangle(Color.DarkRed, 15, iznyy, dir.Length * 8, 15);
                    txtxtx.FontDrawer.WriteText(dir, 15, iznyy, Color.Black);
                    if (Hattory.Kernel.CheackClick(15, iznyy, dir.Length * 8, 16))
                    {
                        path = path + dir + @"\";
                    }
                    iznyy += 16;
                }
                //files
                foreach (string pathhh in files_list)
                {
                    canvas.DrawFilledRectangle(Color.DarkGreen, 150, iznai, pathhh.Length * 8, 15);
                    txtxtx.FontDrawer.WriteText(pathhh, 150, iznai, Color.Black);
                    //OPEN FILE TXT | BMP
                    if (Hattory.Kernel.CheackClick(150, iznai, pathhh.Length * 8, 15))
                    {
                        try
                        {
                            if (pathhh.EndsWith(".txt") || pathhh.EndsWith(".Txt") || pathhh.EndsWith(".tXt") || pathhh.EndsWith(".txT") || pathhh.EndsWith(".TXt") || pathhh.EndsWith(".tXT") || pathhh.EndsWith(".TxT") || pathhh.EndsWith(".TXT"))
                            {
                                txta = File.ReadAllText(path + @"\" + pathhh);
                                @fileeepath = pathhh;
                                klavaypr.On = false;
                                isended = false;
                            }
                            if (pathhh.EndsWith(".bmp") || pathhh.EndsWith(".Bmp") || pathhh.EndsWith(".bMp") || pathhh.EndsWith(".bmP") || pathhh.EndsWith(".BMp") || pathhh.EndsWith(".bMP") || pathhh.EndsWith(".BmP") || pathhh.EndsWith(".BMP"))
                            {
                                try
                                {
                                    bite = File.ReadAllBytes(path + @"\" + pathhh);
                                    image = new sus.Graphics.Bitmap(bite);
                                    if (image.Width <= 1100 && image.Height <= 700 && isendedbmp == true)
                                    {
                                        isendedbmp = false;
                                    }
                                }
                                catch (Exception) { }
                            }
                        }
                        catch (Exception) { }
                    }
                    //DELETE
                    else if (Hattory.Kernel.CheackClickMiddle(150, iznai, pathhh.Length * 8, 15) && islock == false)
                    {
                        try
                        {
                            islock = true;
                            filenameeee = pathhh;
                            Hattory.Kernel.isformatsure = true;
                        }
                        catch (Exception) { }
                    }
                    iznai += 16;
                }
                //RENAME
                if (Hattory.Kernel.CheackClickMiddle(150, 90, 270 + path.Length * 2, 220) && islock == false)
                {
                    islock = true;
                    klavaypr.On = false;
                    Hattory.Kernel.isfilerename = true;
                }
                if (isended == false)
                {
                    entname(fileeepath);
                }
                if (isendedbmp == false)
                {
                    canvas.DrawImageAlpha(image, 350, 60);
                    if (Hattory.Kernel.CheackClickRight(350, 60, (int)image.Width, (int)image.Height))
                    {
                        isendedbmp = true;
                    }
                }
                Cosmos.Core.Memory.Heap.Collect();
            }
            catch (Exception) { }
        }
        public static void entname(string pathFile)
        {
            try
            {
                sus.KeyEvent k;
                bool IsKeyPressed = sus.KeyboardManager.TryReadKey(out k);
                txtxtx.FontDrawer.WriteText("Redact " + pathFile + ":", 10, 270, Color.Red);
                txtxtx.FontDrawer.WriteText(txta, 10, 290, Color.White);
                if (k.Key == ConsoleKeyy.Spacebar)
                {
                    txta += " ";
                }
                else if (k.Key == ConsoleKeyy.Backspace)
                {
                    txta = txta.Remove(txta.Length - 1);
                }
                else if (k.Key == ConsoleKeyy.Escape)
                {
                    txta = "";
                    klavaypr.On = true;
                    isended = true;
                }
                else if (k.Key == ConsoleKeyy.Enter)
                {
                    try
                    {
                        File.WriteAllText(path + @"\" + @pathFile, txta);
                        txta = "";
                        klavaypr.On = true;
                        isended = true;
                    }
                    catch (Exception)
                    {
                        sus.Power.Shutdown();
                    }
                }
                else
                {
                    if (k.KeyChar != 'ｔ')
                    {
                        txta += k.KeyChar;
                    }
                }
            }
            catch (Exception) { }
        }
    }
}
