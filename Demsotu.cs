using System;

namespace dem_so_tu
{
    class Program
    {
        static void Main(string[] args)
        {
            string str; 
            int bien_dem, l;

         
            Console.Write("Nhap nhanh len em: ");
            str = Console.ReadLine();

            l = 0;
            bien_dem = 1;

            /* lap toi phan cuoi cua chuoi */
            while (l <= str.Length - 1)
            {
                /* kiem tra xem ky tu hien tai co phai la khoang trang 
                 * hay la ky tu new line hay ky tu tab */
                if (str[l] == ' ' || str[l] == '\n' || str[l] == '\t')
                {
                    bien_dem++;
                }

                l++;
            }

            Console.Write("So tu la  : {0}\n", bien_dem);

            Console.ReadKey();
        }
    }
}