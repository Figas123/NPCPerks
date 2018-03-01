using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPCPerks
{
    class Program
    {
        static void Main(string[] args)
        {
            string str, escolha, restart;
            int nNPC;
            int[][] skills;

            Console.WriteLine("Quantos NPC's queres spawnar?\n");
            str = Console.ReadLine();
            nNPC = Convert.ToInt32(str);
            Console.WriteLine("");

            for (int i = 0; i < nNPC; i++)
            {
                skills = new int[nNPC][];
                skills[i] = new int[4] { 1, 1, 1, 1 };

                while (true)
                {

                    Console.WriteLine("Aqui estao as caracteristicas do " + (i + 1) + "º NPC?\n");
                    Console.WriteLine($"Stealth = {skills[i][0]}\nCombat = {skills[i][1]}\nLockpick = {skills[i][2]}\nLuck = {skills[i][3]}\n");
                    Console.WriteLine("Que caracteristica queres modificar?\n");
                    escolha = Console.ReadLine();
                    Console.WriteLine("");

                    switch (escolha)
                    {
                        case "Stealth":
                            skills[i][0] = 2;
                            break;
                        case "Combat":
                            skills[i][1] = 2;
                            break;
                        case "Lockpick":
                            skills[i][2] = 2;
                            break;
                        case "Luck":
                            skills[i][3] = 2;
                            break;
                        default:
                            Console.WriteLine("Escolhe uma caracteristica válida por favor...\n");
                            break;
                    }

                    Console.WriteLine($"Stealth = {skills[i][0]}\nCombat = {skills[i][1]}\nLockpick = {skills[i][2]}\nLuck = {skills[i][3]}\n");
                    
                    Console.WriteLine("Queres escolher outra caracteristica? (Sim / Nao)\n");
                    restart = Console.ReadLine();
          
                    if (restart == "Sim")
                    {
                        Console.WriteLine("");
                        continue;
                    }
                    else if (restart == "Nao")
                    {
                        Console.WriteLine("");

                        if (i == (nNPC - 1))
                        {
                            for (i = 0; i < nNPC; i++)
                            {
                                Console.WriteLine($"{i + 1}º NPC:\n\tStealth = {skills[i][0]};\n\tCombat = {skills[i][1]};\n\tLockpick = {skills[i][2]};\n\tLuck = {skills[i][3]}\n\n");
                            }
                            Console.ReadKey();
                        }
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Default Nao\n");
                        Console.WriteLine("");

                        if (i == (nNPC - 1))
                        {
                            for (i = 0; i < nNPC; i++)
                            {
                                Console.WriteLine($"{i + 1}º NPC:\n\tStealth = {skills[i][0]};\n\tCombat = {skills[i][1]};\n\tLockpick = {skills[i][2]};\n\tLuck = {skills[i][3]}\n\n");
                            }
                            Console.ReadKey();
                        }
                        break;
                    }
                }
            }
        }
    }
}
