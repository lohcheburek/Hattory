using Cosmos.System.Graphics;
using System;
using System.IO;
using System.Drawing;
using sus = Cosmos.System;
using ConsoleKeyy = Cosmos.System.ConsoleKeyEx;
using Cosmos.Core;
using IL2CPU.API.Attribs;
using Cosmos.System.FileSystem;
using Cosmos.System.FileSystem.VFS;
using Cosmos.HAL.Drivers.Video;
using kalavaypravlenie;
using Cosmos.Core.Multiboot;
using Cosmos.HAL;

#pragma warning disable CA1416 // бля меня этот ебучий варнинг заебал

namespace Hattory
{
    public class Kernel : sus.Kernel
    {

        //=====CANVAS======

        public static Canvas canvas;

        //====BOOLEANS====

        public static bool ispysk; //knopka pysk
        public static bool ispcinfo; //pc information
        public static bool iscolors; //color changer
        public static bool iscalc; //calculator
        public static bool istaskm; //hardware monitor (old task manager)
        public static bool isdiskman; //disk manager
        public static bool oboi; //show the wallpaper or not?
        public static bool isalwaysshowfps; //always true
        public static bool FVGAIU = false; //FUCKING VIDEO GRAPHICS ARRAY INTERFACE and something on U.
        public static bool isfilemanager; // file manager
        public static bool iscalcready = false; //idk lol, something for normal calculator work. I wrote this in 2021
        public static bool isformatsure = false; //Are you want to delete file?
        public static bool isfilerename = false; //Are you want to rename file?
        public static bool issettingmenu = false; // menu with PC management tools
        public static bool shutdown; // Do you want to shutdown the computer?

        //====OTHER====

        public static int memsec; // variable for time in system
        public static string first; //for calculator
        public static string second; //for calculator
        public static long firstI; //for calculator
        public static long secondI; //for calculator
        public static float c; //for calculator
        public static int globaldskcnt = 0; //current disk number
        public static Color colora; //system background color
        public static sus.FileSystem.CosmosVFS fs = new CosmosVFS(); //FS
        [ManifestResourceStream(ResourceName = "Hattory.krab.bmp")] public static byte[] krabsburger;
        [ManifestResourceStream(ResourceName = "Hattory.cursor.bmp")] public static byte[] tallc;
        public static sus.Graphics.Bitmap image = new sus.Graphics.Bitmap(krabsburger);
        public static sus.Graphics.Bitmap tc = new sus.Graphics.Bitmap(tallc);
        protected override void BeforeRun()
        {
            try
            {
                //Console.Beep(2000, 100);
                //canvas.Clear(1);
                //canvas.DrawImage(BIMG, 0, 0);
                //canvas.Display();
                //Console.Beep(2000, 1000);
                memsec = 61;
                oboi = true;
                isdiskman = false;
                ispysk = false;
                ispcinfo = false;
                iscolors = false;
                iscalc = false;
                isfilemanager = false;
                istaskm = false;
                try
                {
                    VFSManager.RegisterVFS(fs);
                }
                catch (Exception) { } //FILE SYSTEM
                //GRAPHICS SELECT PHASE
                bool canvber()
                {
                    if (VBEDriver.ISAModeAvailable()) { return true; }
                    if (PCI.Exists(VendorID.VirtualBox, DeviceID.VBVGA)) { return true; }
                    if (PCI.Exists(VendorID.Bochs, DeviceID.BGA)) { return true; }
                    if (Multiboot2.IsVBEAvailable) { return true; }
                    return false;
                }
                colora = Color.Black;
                if (PCI.GetDevice(VendorID.VMWare, DeviceID.SVGAIIAdapter) != null && PCI.Exists(PCI.GetDevice(VendorID.VMWare, DeviceID.SVGAIIAdapter)))
                {
                    canvas = new SVGAIICanvas(new Mode(800, 600, ColorDepth.ColorDepth32));
                }
                else if (canvber())
                {
                    canvas = new VBECanvas(new Mode(800, 600, ColorDepth.ColorDepth32));
                }
                else
                {
                    canvas = new VGACanvas();
                    canvas.Mode = new Mode(640, 480, ColorDepth.ColorDepth4);
                    FVGAIU = true;
                }
                if (!FVGAIU)
                {
                    sus.MouseManager.ScreenWidth = canvas.Mode.Width;
                    sus.MouseManager.ScreenHeight = canvas.Mode.Height;
                }
                else
                {
                    sus.MouseManager.ScreenWidth = 640;
                    sus.MouseManager.ScreenHeight = 480;
                }
                sus.MouseManager.X = sus.MouseManager.ScreenWidth/2;
                sus.MouseManager.Y = sus.MouseManager.ScreenHeight/2;
                FPSShow.FpsShower.ShouldRender = true;
                //Console.Beep(3000, 1000);
            }
            catch (Exception e)
            {
                canvas.Disable();
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Vse, kina ne bydet!");
                Console.Write("ERROR CODE: " + e.Message);
            }
        }
        public static bool CheackClick(int x, int y, int w, int h)
        {
            if (sus.MouseManager.X <= x + w && sus.MouseManager.X >= x)
            {
                if (sus.MouseManager.Y <= y + h && sus.MouseManager.Y >= y)
                {
                    if (sus.MouseManager.MouseState == sus.MouseState.Left)
                    {
                        sus.MouseManager.MouseState = sus.MouseState.None;
                        return true;
                    }
                }
            }
            return false;
        }
        public static bool CheackClickMiddle(int x, int y, int w, int h)
        {
            if (sus.MouseManager.X <= x + w && sus.MouseManager.X >= x)
            {
                if (sus.MouseManager.Y <= y + h && sus.MouseManager.Y >= y)
                {
                    if (sus.MouseManager.MouseState == sus.MouseState.Middle)
                    {
                        sus.MouseManager.MouseState = sus.MouseState.None;
                        return true;
                    }
                }
            }
            return false;
        }
        public static bool CheackClickInfinity(int x, int y, int w, int h)
        {
            if (sus.MouseManager.X <= x + w && sus.MouseManager.X >= x)
            {
                if (sus.MouseManager.Y <= y + h && sus.MouseManager.Y >= y)
                {
                    if (sus.MouseManager.MouseState == sus.MouseState.Left)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public static bool CheackPos(int x, int y, int w, int h)
        {
            if (sus.MouseManager.X <= x + w && sus.MouseManager.X >= x)
            {
                if (sus.MouseManager.Y <= y + h && sus.MouseManager.Y >= y)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool CheackClickRight(int x, int y, int w, int h)
        {
            if (sus.MouseManager.X <= x + w && sus.MouseManager.X >= x)
            {
                if (sus.MouseManager.Y <= y + h && sus.MouseManager.Y >= y)
                {
                    if (sus.MouseManager.MouseState == sus.MouseState.Right)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        protected override void Run()
        {
            try
            {
                canvas.Clear(colora);
                //oboi
                if (oboi == true)
                {
                   canvas.DrawImage(image, 0, 0);
                }
                //pysk
                canvas.DrawFilledRectangle(Color.Indigo, 0, 0, 800, 50);
                canvas.DrawFilledCircle(Color.SlateBlue, 765, 25, 20);
                //time
                int mont;
                mont = DateTime.Now.Month;
                string montt = "";
                switch (mont)
                {
                    case 01:
                        montt = "January";
                        break;
                    case 02:
                        montt = "February";
                        break;
                    case 03:
                        montt = "March";
                        break;
                    case 04:
                        montt = "April";
                        break;
                    case 05:
                        montt = "May";
                        break;
                    case 06:
                        montt = "June";
                        break;
                    case 07:
                        montt = "July";
                        break;
                    case 08:
                        montt = "August";
                        break;
                    case 09:
                        montt = "September";
                        break;
                    case 10:
                        montt = "October";
                        break;
                    case 11:
                        montt = "November";
                        break;
                    case 12:
                        montt = "December";
                        break;
                }
                //pysk
                if (CheackPos(745, 0, 45, 50))
                {
                    if (ispysk == false)
                    {
                        ispysk = true;
                    }
                }

                // ----------------------------------------------\
                // CLOSE WINDOWS / CLOSE WINDOWS / CLOSE WINDOWS |
                //-----------------------------------------------/

                //settingd
                if (CheackClickRight(30, 60, 380, 102))
                {
                    if (ispcinfo == true)
                    {
                        ispcinfo = false;
                    }
                }
                //colors
                if (CheackClickRight(30, 60, 270, 75))
                {
                    if (iscolors == true)
                    {
                        iscolors = false;
                    }
                }
                //calc
                if (CheackClickRight(25, 60, 240, 335))
                {
                    if (iscalc == true)
                    {
                        iscalc = false;
                        Calculator.Calc.c = c;
                        Calculator.Calc.first = first;
                        Calculator.Calc.second = second;
                        Calculator.Calc.firstI = firstI;
                        Calculator.Calc.secondI = secondI;
                        Calculator.Calc.iscalcready = false;
                    }
                }
                //taskman
                if (CheackClickRight(645, 510, 150, 85))
                {
                    if (istaskm == true)
                    {
                        istaskm = false;
                    }
                }
                //FileManager
                if (CheackClickRight(10, 60, 270 + Notepad.ntepad.path.Length * 2, 250))
                {
                    if (isfilemanager == true && isformatsure == false)
                    {
                        isfilemanager = false;
                    }
                }
                //DiskManager
                if (CheackClickRight(10, 60, 300, 125))
                {
                    if (isdiskman == true)
                    {
                        isdiskman = false;
                    }
                }

                // ------------------------------------------\
                // CLICKS CLICKS CLICKS CLICKS CLICKS CLICKS |
                //-------------------------------------------/

                //====SettingMenu
                if (CheackClick(665, 52, 96, 15))
                {
                    if (ispysk)
                    {
                        if (!issettingmenu)
                        {
                            isfilemanager = false;
                            shutdown = false;
                            iscalcready = false;
                            issettingmenu = true;
                            ispysk = false; //knopka pysk
                            ispcinfo = false; //pc information
                            iscolors = false; //color changer
                            iscalc = false; //calculator
                            isdiskman = false; //disk manager
                            isfilerename = false; //Are you want to rename file?
                            if (isformatsure)
                            {
                                Notepad.ntepad.islock = false;
                                isformatsure = false; //Are you want to delete file?
                            }
                            else if (isfilerename)
                            {
                                Notepad.ntepad.islock = false;
                                Notepad.ntepad.filename = "";
                                klavaypr.On = true;
                                isfilerename = false;
                            }
                        }
                    }
                }
                //====FILE MANAGER
                if (CheackClick(665, 67, 112, 15))
                {
                    if (ispysk)
                    {
                        if (!isfilemanager)
                        {
                            isfilemanager = true;
                            shutdown = false;
                            iscalcready = false;
                            issettingmenu = false;
                            ispysk = false; //knopka pysk
                            ispcinfo = false; //pc information
                            iscolors = false; //color changer
                            iscalc = false; //calculator
                            isdiskman = false; //disk manager
                            isfilerename = false; //Are you want to rename file?
                            if (isformatsure)
                            {
                                Notepad.ntepad.islock = false;
                                isformatsure = false; //Are you want to delete file?
                            }
                            else if (isfilerename)
                            {
                                Notepad.ntepad.islock = false;
                                Notepad.ntepad.filename = "";
                                klavaypr.On = true;
                                isfilerename = false;
                            }
                        }
                    }
                }
                //====CALCULATOR
                if (CheackClick(665, 82, 96, 15))
                {
                    if (ispysk == true)
                    {
                        if (iscalc == false)
                        {
                            isfilemanager = false;
                            c = 0;
                            firstI = 0;
                            secondI = 0;
                            first = "";
                            second = "";
                            shutdown = false;
                            iscalcready = false;
                            issettingmenu = false;
                            ispysk = false; //knopka pysk
                            ispcinfo = false; //pc information
                            iscolors = false; //color changer
                            iscalc = true; //calculator
                            isdiskman = false; //disk manager
                            isfilerename = false; //Are you want to rename file?
                            if (isformatsure)
                            {
                                Notepad.ntepad.islock = false;
                                isformatsure = false; //Are you want to delete file?
                            }
                            else if (isfilerename)
                            {
                                Notepad.ntepad.islock = false;
                                Notepad.ntepad.filename = "";
                                klavaypr.On = true;
                                isfilerename = false;
                            }
                        }
                    }
                }
                //====disable pysk
                if (sus.MouseManager.MouseState == sus.MouseState.Right)
                {
                    if (ispysk == true)
                    {
                        ispysk = false;
                    }
                }
                //====shutdown
                if (CheackClick(665, 150, 30, 30))
                {
                    if (ispysk)
                    {
                        if (!shutdown)
                        {
                            isfilemanager = false;
                            shutdown = true;
                            iscalcready = false;
                            issettingmenu = false;
                            ispysk = false; //knopka pysk
                            ispcinfo = false; //pc information
                            iscolors = false; //color changer
                            iscalc = false; //calculator
                            isdiskman = false; //disk manager
                            isfilerename = false; //Are you want to rename file?
                            if (isformatsure)
                            {
                                isformatsure = false; //Are you want to delete file?
                                Notepad.ntepad.islock = false;
                            }
                            else if (isfilerename)
                            {
                                isfilerename = false;
                                Notepad.ntepad.islock = false;
                                Notepad.ntepad.filename = "";
                                klavaypr.On = true;
                            }
                        }
                    }
                }
                //=====rebbot
                if (CheackClick(705, 150, 30, 30))
                {
                    if (ispysk == true)
                    {
                        sus.Power.Reboot();
                    }
                }

                // ---------------------------------------------\
                // BOOLEANS BOOLEANS BOOLEANS BOOLEANS BOOLEANS |
                //----------------------------------------------/

                //====shutdown MENU
                if (shutdown)
                {
                    //Code generated by HattoryWindowCreator

                    canvas.DrawFilledRectangle(Color.DarkGray, 250, 200, 250, 100); //window background
                    canvas.DrawFilledRectangle(Color.Gray, 390, 240, 100, 50); //button
                    canvas.DrawFilledRectangle(Color.Gray, 260, 240, 100, 50); //button
                    txtxtx.FontDrawer.WriteText("Are you want to shutdown PC?", 260, 210, Color.Black); //CWR=224
                    txtxtx.FontDrawer.WriteText("Yes", 298, 257, Color.Black); //CWR=24
                    txtxtx.FontDrawer.WriteText("No", 432, 257, Color.Black); //CWR=16

                    if (CheackClick(390, 240, 100, 50))
                    {
                        shutdown = false;
                    }

                    if (CheackClick(260, 240, 100, 50))
                    {
                        sus.Power.Shutdown();
                    }
                }
                //====FPS
                if (isalwaysshowfps == true)
                {
                    canvas.DrawFilledRectangle(Color.Black, 0, 1055, 70, 25);
                    txtxtx.FontDrawer.WriteText("FPS: " + (FPSShow.FpsShower.FPS / 2).ToString(), 5, 1060, Color.White);
                }
                //====PCInformation
                if (ispcinfo == true)
                {
                    canvas.DrawFilledRectangle(Color.LightGray, 30, 60, 380, 102);
                    txtxtx.FontDrawer.WriteText("Computer Information", 35, 62, Color.Black);
                    txtxtx.FontDrawer.WriteText("RAM: " + CPU.GetAmountOfRAM().ToString() + "MB", 35, 78, Color.Black);
                    try
                    {
                        txtxtx.FontDrawer.WriteText("CPU: " + CPU.GetCPUBrandString(), 35, 94, Color.Black);
                    }
                    catch (Exception) { }
                    txtxtx.FontDrawer.WriteText("Frames Per Second: " + (FPSShow.FpsShower.FPS / 2).ToString(), 35, 110, Color.Black);
                    txtxtx.FontDrawer.WriteText("Video Driver: " + canvas.Name(), 35, 126, Color.Black);
                    txtxtx.FontDrawer.WriteText("Resolution: " + canvas.Mode.Width + "x" + canvas.Mode.Height + " 32 bit color", 35, 142, Color.Black);
                    if (CheackClick(35, 110, 176, 16))
                    {
                        if (isalwaysshowfps == false)
                        {
                            isalwaysshowfps = true;
                        }
                        else if (isalwaysshowfps == true)
                        {
                            isalwaysshowfps = false;
                        }
                    }
                }
                //====SETTING MENU
                if (issettingmenu == true)
                {
                    //Code generated by HattoryWindowCreator

                    canvas.DrawFilledRectangle(Color.DarkGray, 100, 100, 200, 150);
                    txtxtx.FontDrawer.WriteText("Disk Manager", 110, 170, Color.Black);
                    txtxtx.FontDrawer.WriteText("Hardware Monitor", 110, 150, Color.Black);
                    txtxtx.FontDrawer.WriteText("PC Information", 110, 130, Color.Black);
                    txtxtx.FontDrawer.WriteText("Colors", 110, 110, Color.Black);
                    txtxtx.FontDrawer.WriteText("Close", 110, 215, Color.Black);
                    //colors
                    if (CheackClick(110, 110, 48, 16))
                    {
                        if (iscolors == false)
                        {
                            ispcinfo = false;
                            ispysk = false;
                            iscalc = false;
                            isfilemanager = false;
                            isdiskman = false;
                            iscolors = true;
                            issettingmenu = false;
                        }
                    }
                    //PCInf
                    if (CheackClick(110, 130, 112, 16))
                    {
                        if (ispcinfo == false)
                        {
                            iscolors = false;
                            ispysk = false;
                            isdiskman = false;
                            iscalc = false;
                            isfilemanager = false;
                            ispcinfo = true;
                            issettingmenu = false;
                        }
                    }
                    //HM
                    if (CheackClick(110, 150, 128, 16))
                    {
                        if (istaskm == false)
                        {
                            istaskm = true;
                        }
                    }
                    //DM
                    if (CheackClick(110, 170, 96, 16))
                    {
                        if (isdiskman == false)
                        {
                            iscalcready = false;
                            isfilemanager = false;
                            ispcinfo = false;
                            ispysk = false;
                            iscolors = false;
                            iscalc = false;
                            isdiskman = true;
                            issettingmenu = false;
                        }
                    }
                    //Close
                    if (CheackClick(110, 215, 40, 16))
                    {
                        issettingmenu = false;
                    }
                }
                //====FILE MANAGER
                if (isfilemanager == true)
                {
                    //Notepad.ntepad.path = globaldskcnt.ToString() + @":\";
                    Notepad.ntepad.enternote();
                }
                //===COLOR CHANGER
                if (iscolors == true)
                {
                    canvas.DrawFilledRectangle(Color.LightGray, 30, 60, 270, 75);
                    canvas.DrawFilledRectangle(Color.MidnightBlue, 35, 65, 75, 30);
                    canvas.DrawFilledRectangle(Color.Black, 115, 65, 75, 30);
                    txtxtx.FontDrawer.WriteText("Wallpaper", 117, 80, Color.White);
                    canvas.DrawFilledRectangle(Color.Navy, 195, 65, 75, 30);
                    canvas.DrawFilledRectangle(Color.DarkSlateGray, 35, 100, 75, 30);
                    canvas.DrawFilledRectangle(Color.Black, 115, 100, 75, 30);
                    canvas.DrawFilledRectangle(Color.Teal, 195, 100, 75, 30);
                    if (CheackClick(35, 65, 75, 30))
                    {
                        colora = Color.MidnightBlue;
                    }
                    if (CheackClick(115, 65, 75, 30))
                    {
                        if (oboi == false)
                        {
                            oboi = true;
                        }
                        else if (oboi == true)
                        {
                            oboi = false;
                        }
                    }
                    if (CheackClick(195, 65, 75, 30))
                    {
                        colora = Color.Navy;
                    }
                    if (CheackClick(35, 100, 75, 30))
                    {
                        colora = Color.DarkSlateGray;
                    }
                    if (CheackClick(115, 100, 75, 30))
                    {
                        colora = Color.Black;
                    }
                    if (CheackClick(195, 100, 75, 30))
                    {
                        colora = Color.Teal;
                    }
                }
                //=====KNOPKA PUSK
                if (ispysk == true)
                {
                    canvas.DrawFilledRectangle(Color.SlateBlue, 660, 50, 140, 140);
                    txtxtx.FontDrawer.WriteText("Settigs Menu", 665, 52, Color.White);
                    txtxtx.FontDrawer.WriteText("File Inspector", 665, 68, Color.White);
                    txtxtx.FontDrawer.WriteText("Calculator", 665, 84, Color.White);
                    canvas.DrawFilledRectangle(Color.Crimson, 665, 150, 30, 30);
                    canvas.DrawFilledRectangle(Color.OrangeRed, 705, 150, 30, 30);
                    //------------------------------
                }
                //=====HARDWARE MONITOR
                if (istaskm == true)
                {
                    float URIM = GCImplementation.GetUsedRAM() / 1024 / 1024;
                    int URpercentage = (int)(URIM / CPU.GetAmountOfRAM() * 100); //get percentage
                    canvas.DrawFilledRectangle(Color.LightGray, 645, 510, 150, 85);
                    txtxtx.FontDrawer.WriteText("Hardware Monitor", 650, 525, Color.Black);
                    txtxtx.FontDrawer.WriteText("RAM Usage in MBs:", 650, 540, Color.Black);
                    canvas.DrawFilledRectangle(Color.DarkGreen, 650, 555, 100, 20);
                    canvas.DrawFilledRectangle(Color.Lime, 650, 555, URpercentage, 20);
                    txtxtx.FontDrawer.WriteText(URIM.ToString() + " MBs / " + URpercentage.ToString() + " %", 652, 558, Color.Black);
                    txtxtx.FontDrawer.WriteText("FPS: " + (FPSShow.FpsShower.FPS / 2).ToString(), 650, 575, Color.Black);
                }
                //===CALCULATOR
                if (iscalc == true)
                {
                    Calculator.Calc.Calculator();
                }
                //=====DISK MAMAGER
                if (isdiskman == true)
                {
                    try
                    {
                        canvas.DrawFilledRectangle(Color.Purple, 10, 60, 300, 125);
                        txtxtx.FontDrawer.WriteText("Disks: " + "current - " + globaldskcnt, 15, 65, Color.Black);
                        var diskslist = VFSManager.GetDisks();
                        int iznai = 80;
                        int dskcnt = 0;
                        foreach (var disk in diskslist)
                        {
                            txtxtx.FontDrawer.WriteText("Disk " + dskcnt + " - " + (disk.Size / 1024 / 1024) + "MB, " + "MBR: " + disk.IsMBR, 15, iznai, Color.Black);
                            if (CheackClick(15, iznai, 36, 16))
                            {
                                globaldskcnt = dskcnt;
                                Notepad.ntepad.path = dskcnt + @":\";
                                isfilemanager = true;
                                isdiskman = false;
                            }
                            /*try
                            {
                                disk.Mount();
                            }
                            catch (Exception) { }
                            if (CheackClickRight(15, iznai, 36, 9))
                            {
                                isformatsure = true;
                            }*/
                            dskcnt += 1;
                            iznai += 16;
                        }
                    }
                    catch (Exception) { }
                }
                //======SureDelete
                if (isformatsure == true)
                {
                    canvas.DrawFilledRectangle(Color.LightGray, 400, 240, 100, 50); // 270, 200
                    txtxtx.FontDrawer.WriteText("Delete File?", 405, 245, Color.Black);
                    canvas.DrawFilledRectangle(Color.DarkGray, 415, 260, 35, 25);
                    txtxtx.FontDrawer.WriteText("Yes", 420, 270, Color.Black);
                    canvas.DrawFilledRectangle(Color.DarkGray, 455, 260, 35, 25);
                    txtxtx.FontDrawer.WriteText("No", 465, 270, Color.Black);
                    if (CheackClick(415, 260, 35, 25))
                    {
                        File.Delete(Notepad.ntepad.path + @"\" + Notepad.ntepad.filenameeee);
                        Notepad.ntepad.islock = false;
                        isformatsure = false;
                    }
                    if (CheackClick(455, 260, 35, 25))
                    {
                        //Directory.CreateDirectory(@"0:\");
                        Notepad.ntepad.islock = false;
                        isformatsure = false;
                    }
                }
                //=====RenameFile
                if (isfilerename == true)
                {
                    canvas.DrawFilledRectangle(Color.Gray, 305, 240, 180, 50); // 270, 200       //420
                    txtxtx.FontDrawer.WriteText("Create file with name:", 310, 245, Color.Black); //775
                    try
                    {
                        sus.KeyEvent k;
                        bool IsKeyPressed = sus.KeyboardManager.TryReadKey(out k);
                        txtxtx.FontDrawer.WriteText(Notepad.ntepad.filename, 310, 260, Color.Black);
                        if (k.Key == ConsoleKeyy.Spacebar)
                        {
                            Notepad.ntepad.filename += " ";
                        }
                        else if (k.Key == ConsoleKeyy.Backspace)
                        {
                            Notepad.ntepad.filename = Notepad.ntepad.filename.Remove(Notepad.ntepad.filename.Length - 1);
                        }
                        else if (k.Key == ConsoleKeyy.Escape)
                        {
                            Notepad.ntepad.filename = "";
                            Notepad.ntepad.islock = false;
                            klavaypr.On = true;
                            isfilerename = false;
                        }
                        else if (k.Key == ConsoleKeyy.Enter)
                        {
                            try
                            {
                                File.Create(Notepad.ntepad.path + @"\" + Notepad.ntepad.filename);
                                Notepad.ntepad.filename = "test.txt";
                                Notepad.ntepad.islock = false;
                                klavaypr.On = true;
                                isfilerename = false;
                            }
                            catch (Exception)
                            {
                                Notepad.ntepad.filename = "";
                                Notepad.ntepad.islock = false;
                                klavaypr.On = true;
                                isfilerename = false;
                            }
                        }
                        else
                        {
                            if (k.KeyChar != 'ｔ')
                            {
                                Notepad.ntepad.filename += k.KeyChar;
                            }
                        }
                    }
                    catch(Exception) { }
                }

                // ------------------------------------------\
                // OTHER OTHER OTHER OTHER OTHER OTHER OTHER |
                //-------------------------------------------/

                //Time
                if (memsec != DateTime.Now.Second)
                {
                    txtxtx.FontDrawer.WriteText(DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString(), 5, 1, Color.White);
                    txtxtx.FontDrawer.WriteText(montt, 5, 17, Color.White);
                    txtxtx.FontDrawer.WriteText(DateTime.Now.Day.ToString() + "th " + DateTime.Now.Year.ToString(), 5, 33, Color.White);
                }
                //mouse
                try
                {
                    canvas.DrawImageAlpha(tc, (int)sus.MouseManager.X, (int)sus.MouseManager.Y);
                }
                catch (Exception) { } 
                kalavaypravlenie.klavaypr.YPRklava();
                canvas.Display();
                Cosmos.Core.Memory.Heap.Collect();
            }
            catch (Exception)
            {
                sus.Power.Shutdown();
            }
        }
    }
}