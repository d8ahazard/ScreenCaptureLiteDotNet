using System.Runtime.InteropServices;

namespace ScreenCaptureLiteDotNet {
    public class ScreenCapture {
        [StructLayout(LayoutKind.Sequential)]
        public struct Point {
            public int x;
            public int y;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct MousePoint {
            public Point Position;
            public Point HotSpot;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct Window {
            public uint Handle;
            public Point Position;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct Image {
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct ImageBGRA {
            public char B;
            public char G;
            public char R;
            public char A;
        }

        [StructLayout(LayoutKind.Sequential)]  
        public struct Monitor {  
            public int Id;
            public int Index;
            public int Adapter;
            public int Height;
            public int Width;
            public int OriginalHeight;
            public int OriginalWidth;
            // Offsets are the number of pixels that a monitor can be from the origin. For example, users can shuffle their
            // monitors around so this affects their offset.
            public int OffsetX;
            public int OffsetY;
            public int OriginalOffsetX;
            public int OriginalOffsetY;
            public string Name;
            public float Scaling;
        }
        
        [DllImport("./lib/screen_capture_lite.dll", EntryPoint = @"?Index@Screen_Capture@SL@@YAHAEBUMonitor@12@@Z")]
        public static extern int Index(Monitor monitor);
        [DllImport("./lib/screen_capture_lite.dll", EntryPoint = @"?Id@Screen_Capture@SL@@YAHAEBUMonitor@12@@Z")]
        public static extern int Id(Monitor monitor);
        
        [DllImport("./lib/screen_capture_lite.dll", EntryPoint = @"?Adapter@Screen_Capture@SL@@YAHAEBUMonitor@12@@Z")]
        public static extern int Adapter(Monitor monitor);
        
        [DllImport("./lib/screen_capture_lite.dll", EntryPoint = @"?OffsetX@Screen_Capture@SL@@YAHAEBUMonitor@12@@Z")]
        public static extern int OffsetX(Monitor monitor);
        [DllImport("./lib/screen_capture_lite.dll", EntryPoint = @"?OffsetY@Screen_Capture@SL@@YAHAEBUMonitor@12@@Z")]
        public static extern int OffsetY(Monitor monitor);
        [DllImport("./lib/screen_capture_lite.dll", EntryPoint = @"?OffsetX@Screen_Capture@SL@@YAXAEAUMonitor@12@H@Z")]
        public static extern void OffsetX(Monitor monitor, int x);
        [DllImport("./lib/screen_capture_lite.dll", EntryPoint = @"?OffsetY@Screen_Capture@SL@@YAXAEAUMonitor@12@H@Z")]
        public static extern void OffsetY(Monitor monitor, int y);
        [DllImport("./lib/screen_capture_lite.dll", EntryPoint = @"?OffsetX@Screen_Capture@SL@@YAHAEBUWindow@12@@Z")]
        public static extern int OffsetX(Window window);
        [DllImport("./lib/screen_capture_lite.dll", EntryPoint = @"?OffsetY@Screen_Capture@SL@@YAHAEBUWindow@12@@Z")]
        public static extern int OffsetY(Window window);
        [DllImport("./lib/screen_capture_lite.dll", EntryPoint = @"?OffsetX@Screen_Capture@SL@@YAXAEAUWindow@12@H@Z")]
        public static extern void OffsetX(Window window, int x);
        [DllImport("./lib/screen_capture_lite.dll", EntryPoint = @"?OffsetY@Screen_Capture@SL@@YAXAEAUWindow@12@H@Z")]
        public static extern void OffsetY(Window window, int y);
        
        [DllImport("./lib/screen_capture_lite.dll", EntryPoint = @"?Name@Screen_Capture@SL@@YAHAEBUMonitor@12@@Z")]
        public static extern char Name(Monitor monitor);
        [DllImport("./lib/screen_capture_lite.dll", EntryPoint = @"?Name@Screen_Capture@SL@@YAHAEBUWindow@12@@Z")]
        public static extern char Name(Window window);
        
        [DllImport("./lib/screen_capture_lite.dll", EntryPoint = @"?Height@Screen_Capture@SL@@YAHAEBUImage@12@@Z")]
        public static extern int Height(Image img);
        [DllImport("./lib/screen_capture_lite.dll", EntryPoint = @"?Height@Screen_Capture@SL@@YAHAEBUMonitor@12@@Z")]
        public static extern int Height(Monitor monitor);
        [DllImport("./lib/screen_capture_lite.dll", EntryPoint = @"?Height@Screen_Capture@SL@@YAHAEBUWindow@12@@Z")]
        public static extern int Height(Window window);
        [DllImport("./lib/screen_capture_lite.dll", EntryPoint = @"?Height@Screen_Capture@SL@@YAXAEAUMonitor@12@H@Z")]
        public static extern void Height(Monitor monitor, int h);
        [DllImport("./lib/screen_capture_lite.dll", EntryPoint = @"?Height@Screen_Capture@SL@@YAXAEAUWindow@12@H@Z")]
        public static extern void Height(Window window, int h);

        [DllImport("./lib/screen_capture_lite.dll", EntryPoint = @"?Width@Screen_Capture@SL@@YAHAEBUImage@12@@Z")]
        public static extern int Width(Image img);
        [DllImport("./lib/screen_capture_lite.dll", EntryPoint = @"?Width@Screen_Capture@SL@@YAHAEBUMonitor@12@@Z")]
        public static extern int Width(Monitor monitor);
        [DllImport("./lib/screen_capture_lite.dll", EntryPoint = @"?Width@Screen_Capture@SL@@YAHAEBUWindow@12@@Z")]
        public static extern int Width(Window window);
        [DllImport("./lib/screen_capture_lite.dll", EntryPoint = @"?Width@Screen_Capture@SL@@YAXAEAUMonitor@12@H@Z")]
        public static extern void Width(Monitor monitor, int h);
        [DllImport("./lib/screen_capture_lite.dll", EntryPoint = @"?Width@Screen_Capture@SL@@YAXAEAUWindow@12@H@Z")]
        public static extern void Width(Window window, int h);
        
        [DllImport("./lib/screen_capture_lite.dll", EntryPoint = @"?X@Screen_Capture@SL@@YAHAEBUPoint@12@@Z")]
        public static extern int X(Point p);
        [DllImport("./lib/screen_capture_lite.dll", EntryPoint = @"?Y@Screen_Capture@SL@@YAHAEBUPoint@12@@Z")]
        public static extern int Y(Point p);
        
        [DllImport("./lib/screen_capture_lite.dll", EntryPoint = @"?StartSrc@Screen_Capture@SL@@YAPEBUImageBGRA@12@AEBUImage@12@@Z")]
        public static extern ImageBGRA StartSrc(Image img);
        
        [DllImport("./lib/screen_capture_lite.dll", EntryPoint = @"?GotoNextRow@Screen_Capture@SL@@YAPEBUImageBGRA@12@AEBUImage@12@PEBU312@@Z")]
        public static extern ImageBGRA GotoNextRow(Image img, ImageBGRA current);
        [DllImport("./lib/screen_capture_lite.dll", EntryPoint = @"?isDataContiguous@Screen_Capture@SL@@YA_NAEBUImage@12@@Z")]
        public static extern bool isDataContiguous(Image img);
        
        [DllImport("./lib/screen_capture_lite.dll", EntryPoint = @"?GetMonitors@Screen_Capture@SL@@YA?AV?$vector@UMonitor@Screen_Capture@SL@@V?$allocator@UMonitor@Screen_Capture@SL@@@std@@@std@@XZ")]
        public static extern Monitor[] GetMonitors();
        [DllImport("./lib/screen_capture_lite.dll", EntryPoint = @"?GetWindows@Screen_Capture@SL@@YA?AV?$vector@UWindow@Screen_Capture@SL@@V?$allocator@UWindow@Screen_Capture@SL@@@std@@@std@@XZ")]
        public static extern Window[] GetWindows();
    }
}