using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace sandbox
{
    class Program
    {
        static string[] fractions = { "", " 1/16", " 1/8", " 3/16", " 1/4", " 5/16", " 3/8", " 7/16", " 1/2", " 9/16", " 5/8", " 11/16", " 3/4", " 13/16", " 7/8", " 15/16" };

        static string[,] imageCode = { { "cwobw", "cwbw", "cpb" }, 
                                { "bdwobw", "bdwbw", "bdpb" }, 
                                { "ewobw", "ewbw", "epb" }, 
                                { "bdawobw", "bdawbw", "bdapb" }, 
                                { "cbpb", "cbwbw", "cbpb"} };

        static void Main(string[] args)
        {
            //double result = Math.Tan(-Math.PI / 2.0);
            //Console.Write("result 1: " + Math.Abs(Math.Abs(result) - 1.63317787283838E+16).ToString() + "\n");
            //Console.Write("result 1: " + result.ToString() + "\n");
            //result = Math.Tan(-3.0 * Math.PI / 2.0);
            //Console.Write("result 3: " + result.ToString() + "\n");
            //result = Math.Tan(-5.0 * Math.PI / 2.0);
            //Console.Write("result 5: " + result.ToString() + "\n");
            //result = Math.Tan(-7.0 * Math.PI / 2.0);
            //Console.Write("result 7: " + result.ToString() + "\n");
            //result = Math.Tan(-9.0 * Math.PI / 2.0);
            //Console.Write("result 9: " + result.ToString() + "\n");
            //result = Math.Tan(-11.0 * Math.PI / 2.0);
            //Console.Write("result 11: " + result.ToString() + "\n");
            //

            //var s = "abcdefgh";
            //Console.WriteLine("ToNearestSixteenth(3000.0, true, true) = " + ToNearestSixteenth(3000.25, true, true));
            //Console.WriteLine("ToNearestSixteenth(3000.0, true, false) = " + ToNearestSixteenth(3000.25, true, false));
            //Console.WriteLine("ToNearestSixteenth(3000.0, false, true) = " + ToNearestSixteenth(3000.25, false, true));
            //Console.WriteLine("ToNearestSixteenth(3000.0, false, false) = " + ToNearestSixteenth(3000.25, false, false));
            //Console.Read();

            //Console.WriteLine(imageCode[2,1]);
            //if (!File.Exists(@"C:\" + String.Empty))
            //    Console.WriteLine("does not fail");
            //
            //RandomLicenseGenerator rlg = new RandomLicenseGenerator();
            //Console.WriteLine(rlg.LicenseGen());
            //Console.WriteLine(rlg.LicenseGen());
            //Console.WriteLine(rlg.LicenseGen());
            //Console.WriteLine(rlg.LicenseGen());
            //Console.WriteLine(DateTime.Now.ToString("MM-dd-yyyy"));
            //DateTime dt = new DateTime(2015, 2, 21);
            
            //if (dt > DateTime.Now)
            //    Console.WriteLine("Ok. Not Expired");
            //else
            //    Console.WriteLine("Expired");
            // first 28 property ids
            Console.WriteLine("");
            Console.WriteLine("HEX 2 INT[0x0001] PropertyTagGpsVer =            " + Convert.ToInt32("0x0001", 16).ToString());
            Console.WriteLine("HEX 2 INT[0x0002] PropertyTagGpsLatitude =       " + Convert.ToInt32("0x0002", 16).ToString());
            Console.WriteLine("HEX 2 INT[0x0003] PropertyTagGpsLongitudeRef =   " + Convert.ToInt32("0x0003", 16).ToString());
            Console.WriteLine("HEX 2 INT[0x0004] PropertyTagGpsLongitude =      " + Convert.ToInt32("0x0004", 16).ToString());
            Console.WriteLine("HEX 2 INT[0x0005] PropertyTagGpsAltitudeRef =    " + Convert.ToInt32("0x0005", 16).ToString());
            Console.WriteLine("HEX 2 INT[0x0006] PropertyTagGpsAltitude =       " + Convert.ToInt32("0x0006", 16).ToString());
            Console.WriteLine("HEX 2 INT[0x0007] PropertyTagGpsGpsTime =        " + Convert.ToInt32("0x0007", 16).ToString());
            Console.WriteLine("HEX 2 INT[0x0008] PropertyTagGpsGpsSatellites =  " + Convert.ToInt32("0x0008", 16).ToString());
            Console.WriteLine("HEX 2 INT[0x0009] PropertyTagGpsGpsStatus =      " + Convert.ToInt32("0x0009", 16).ToString());
            Console.WriteLine("HEX 2 INT[0x000A] PropertyTagGpsGpsMeasureMode = " + Convert.ToInt32("0x000A", 16).ToString());
            Console.WriteLine("HEX 2 INT[0x000B] PropertyTagGpsGpsDop =         " + Convert.ToInt32("0x000B", 16).ToString());
            Console.WriteLine("HEX 2 INT[0x000C] PropertyTagGpsSpeedRef =       " + Convert.ToInt32("0x000C", 16).ToString());
            Console.WriteLine("HEX 2 INT[0x000D] PropertyTagGpsSpeed =          " + Convert.ToInt32("0x000D", 16).ToString());
            Console.WriteLine("HEX 2 INT[0x000E] PropertyTagGpsTrackRef =       " + Convert.ToInt32("0x000E", 16).ToString());
            Console.WriteLine("HEX 2 INT[0x000F] PropertyTagGpsTrack =          " + Convert.ToInt32("0x000F", 16).ToString());
            Console.WriteLine("HEX 2 INT[0x0010] PropertyTagGpsImgDirRef =      " + Convert.ToInt32("0x0010", 16).ToString());
            
            Console.WriteLine("HEX 2 INT[0x0011] PropertyTagGpsImgDir =         " + Convert.ToInt32("0x0011", 16).ToString());
            Console.WriteLine("HEX 2 INT[0x0012] PropertyTagGpsMapDatum =       " + Convert.ToInt32("0x0012", 16).ToString());
            Console.WriteLine("HEX 2 INT[0x0013] PropertyTagGpsDestLatRef =     " + Convert.ToInt32("0x0013", 16).ToString());
            Console.WriteLine("HEX 2 INT[0x0014] PropertyTagGpsDestLat =        " + Convert.ToInt32("0x0014", 16).ToString());
            Console.WriteLine("HEX 2 INT[0x0015] PropertyTagGpsDestLongRef =    " + Convert.ToInt32("0x0015", 16).ToString());
            Console.WriteLine("HEX 2 INT[0x0016] PropertyTagGpsDestLong =       " + Convert.ToInt32("0x0016", 16).ToString());
            Console.WriteLine("HEX 2 INT[0x0017] PropertyTagGpsDestBearRef =    " + Convert.ToInt32("0x0017", 16).ToString());
            Console.WriteLine("HEX 2 INT[0x0018] PropertyTagGpsDestBear =       " + Convert.ToInt32("0x0018", 16).ToString());
            Console.WriteLine("HEX 2 INT[0x0019] PropertyTagGpsDestDistRef =    " + Convert.ToInt32("0x0019", 16).ToString());
            Console.WriteLine("HEX 2 INT[0x001A] PropertyTagGpsDestDist =       " + Convert.ToInt32("0x001A", 16).ToString());
            Console.WriteLine("HEX 2 INT[0x00FE] PropertyTagNewSubfileType =    " + Convert.ToInt32("0x00FE", 16).ToString());
            Console.WriteLine("HEX 2 INT[0x00FF] PropertyTagSubfileType =       " + Convert.ToInt32("0x00FF", 16).ToString());

            //thru 30
            Console.WriteLine("HEX 2 INT[0x0100] PropertyTagImageWidth =        " + Convert.ToInt32("0x0100", 16).ToString());
            Console.WriteLine("HEX 2 INT[0x0101] PropertyTagImageHeight =       " + Convert.ToInt32("0x0101", 16).ToString());
            
            Console.WriteLine("HEX 2 INT[0x010D] PropertyTagDocumentName =      " + Convert.ToInt32("0x010D", 16).ToString());
            Console.WriteLine("HEX 2 INT[0x010E] PropertyTagImageDescription =  " + Convert.ToInt32("0x010E", 16).ToString());
            Console.WriteLine("HEX 2 INT[0x010F] PropertyTagEquipMake =         " + Convert.ToInt32("0x010F", 16).ToString());

            Console.WriteLine("HEX 2 INT[0x0110] PropertyTagEquipModel =        " + Convert.ToInt32("0x0110", 16).ToString());
            Console.WriteLine("HEX 2 INT[0x0112] PropertyTagOrientation =       " + Convert.ToInt32("0x0112", 16).ToString());

            Console.WriteLine("HEX 2 INT[0x0132] PropertyTagDateTime =          " + Convert.ToInt32("0x0132", 16).ToString());
            Console.WriteLine("HEX 2 INT[0x013B] PropertyTagArtist =            " + Convert.ToInt32("0x013B", 16).ToString());
            Console.WriteLine("HEX 2 INT[0x0320] PropertyTagImageTitle =        " + Convert.ToInt32("0x0320", 16).ToString());


// 0x5012   PropertyTagThumbnailFormat
// 0x5013   PropertyTagThumbnailWidth
//0x5014 PropertyTagThumbnailHeight
//    0x5017 PropertyTagThumbnailRawBytes
//0x5018 PropertyTagThumbnailSize






            Console.Read();
        }

        public static string ToNearestSixteenth(double val, bool useTicks, bool isFeet)
        {
            string result = "";
            string sign = "";
            double feet, inches, remainder;

            if (val < 0.0)
                sign = "-";

            val = Math.Abs(val);

            if (isFeet)
            {
                feet = Math.Truncate(val);
                Debug.Print("feet=" + feet.ToString());
                inches = val * 12;
                Debug.Print("inches=" + inches.ToString());
                inches = inches % 12;
                Debug.Print("inches mod 12=" + inches.ToString());
                remainder = inches - Math.Truncate(inches);
                Debug.Print("remainder=" + remainder.ToString());
                inches = Math.Truncate(inches);
                Debug.Print("inches truncated=" + inches.ToString());
                remainder = Math.Round(remainder / (1.0 / 16.0));
                Debug.Print("remainder truncated=" + remainder.ToString());
            }
            else
            {
                feet = val / 12;
                inches = val % 12;
                remainder = inches - Math.Truncate(inches);
                inches = Math.Truncate(inches);
                remainder = Math.Round(remainder / (1.0 / 16.0));
            }

            if (Math.Truncate(feet).ToString().Trim() == "0")
            {
                if (inches.ToString().Trim() == "0")
                {
                    if (useTicks)
                        result = sign + fractions[Convert.ToInt32(remainder)] + @"""";
                    else
                        result = sign + fractions[Convert.ToInt32(remainder)];
                }
                else
                {
                    if (fractions[Convert.ToInt32(remainder)].Trim().Length == 0)
                    {
                        if (useTicks)
                            result = sign + inches.ToString() + @"""";
                        else
                            result = sign + inches.ToString();
                    }
                    else
                    {
                        if (useTicks)
                            result = sign + inches.ToString() + " " + fractions[Convert.ToInt32(remainder)] + @"""";
                        else
                            result = sign + inches.ToString() + " " + fractions[Convert.ToInt32(remainder)];
                    }
                }
            }
            else
            {
                if (useTicks)
                    result = sign + Math.Truncate(feet).ToString() + "'-" + inches.ToString() + fractions[Convert.ToInt32(remainder)] + @"""";
                else
                    result = sign + Math.Truncate(feet).ToString() + "-" + inches.ToString() + fractions[Convert.ToInt32(remainder)];
            }
            return result;
        }

    }
}
