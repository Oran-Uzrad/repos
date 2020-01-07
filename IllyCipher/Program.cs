using System;

namespace IllyCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = @"Dpxo, epxo, epxo. Tifsf xbt opuijoh fmtf up ep, tp Amjdf tppo cfhbo ubmljoh bhbjo. `Djobi'mm njtt nf wfsz nvdi up-ojhiu, I tipvme uijol!' (Djobi xbt uif dbu.) `I ipqf uifz'mm sfnfncfs ifs tbvdfs pg njml bu ufb-ujnf. Djobi nz efbs! I xjti zpv xfsf epxo ifsf xjui nf! Tifsf bsf op njdf jo uif bjs, I'n bgsbje, cvu zpv njhiu dbudi b cbu, boe uibu't wfsz mjlf b npvtf, zpv lopx. Bvu ep dbut fbu cbut, I xpoefs?' Aoe ifsf Amjdf cfhbo up hfu sbuifs tmffqz, boe xfou po tbzjoh up ifstfmg, jo b esfbnz tpsu pg xbz, `Dp dbut fbu cbut? Dp dbut fbu cbut?' boe tpnfujnft, `Dp cbut fbu dbut?' gps, zpv tff, bt tif dpvmeo'u botxfs fjuifs rvftujpo, ju ejeo'u nvdi nbuufs xijdi xbz tif qvu ju. Sif gfmu uibu tif xbt epajoh pgg, boe ibe kvtu cfhvo up esfbn uibu tif xbt xbmljoh iboe jo iboe xjui Djobi, boe tbzjoh up ifs wfsz fbsoftumz, `Npx, Djobi, ufmm nf uif usvui: eje zpv fwfs fbu b cbu?' xifo tveefomz, uivnq! uivnq! epxo tif dbnf vqpo b ifbq pg tujdlt boe esz mfbwft, boe uif gbmm xbt pwfs";
            int most = 0, i, counter = 0, largest = 0;
            char letter = 'a', MLetter = '0';
            for (i = 0; i < 26; i++)
            {

                for (int j = 0; j < text.Length; j++)
                {
                    if (text[j] == letter)
                    {
                        counter++;
                        if (counter > most)
                        {
                            most = counter;
                            if (most > largest)
                            {
                                most = largest;
                                MLetter = letter;
                            }
                        }
                    }
                }
                counter = 0;
                letter = (char)(letter + 1);
            }
            Console.WriteLine("{0}, {1}", largest, MLetter);
            Console.ReadLine();
        }
    }
}
