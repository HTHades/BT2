using System;
using System.Threading;

namespace VirusTroll
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "⚠️ VirusX - Đang xâm nhập...";
            Console.ForegroundColor = ConsoleColor.Red;

            string[] warnings = {
                "[!] Virus đã xâm nhập hệ thống.",
                "[!] Đang mã hóa dữ liệu...",
                "[!] Upload dữ liệu lên dark web...",
                "[!] Xoá file hệ thống...",
                "[!] Không thể ngắt kết nối!"
            };

            Console.WriteLine("🚨 Khởi động công cụ khai thác hệ thống...\n");
            Thread.Sleep(2000);

            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(warnings[rnd.Next(warnings.Length)]);
                Thread.Sleep(500);
            }

            Console.WriteLine("\nĐang thực hiện quá trình mã hóa:");
            for (int i = 0; i <= 100; i += 5)
            {
                Console.Write($"\rTiến trình: {i}% ");
                Thread.Sleep(150);
            }

            Console.WriteLine("\n\n💀 Máy bạn đã bị kiểm soát hoàn toàn 💀");
            Thread.Sleep(2000);
            Console.WriteLine("...à mà đợi tí...");
            Thread.Sleep(1500);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("😜 ĐÙA THÔI! Đây là trò troll của [TÊN BẠN] 😆");
            Console.WriteLine("Chúc bạn một ngày bớt cả tin hơn 😄");
            Console.ResetColor();
        }
    }
}
