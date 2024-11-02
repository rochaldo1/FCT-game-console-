﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCT_game__console_.Menu
{
    static class RulesPrinter
    {
        public static void Printer()
        {
            Console.WriteLine("~-----------------* Правила игры *-----------------~");
            Console.WriteLine("\tВы выступаете в игре в роли Игрока 1. Игрок 2 скрыт от Вас за экраном компьютера, но" +
                                "он будет отвечать на Ваши действия.\n");
            Console.WriteLine("\tИгра состоит из 2-х партий по времени по 25 минут.");
            Console.WriteLine("\tВ качестве Игрока 2 могут выступать:");
            Console.WriteLine("\t\t@ игрок, которого выбирает компьютер;");
            Console.WriteLine("\t\t@ игроки с именами AA или BB, которых Вы можете выбирать самостоятельно.\n");
            Console.WriteLine("\tПо правлилам игры, Вы можете выбирать один из 3-х вариантов:");
            Console.WriteLine("\t\t1. Игра в 2-х партиях с одним и тем же Игроком 2, которого выбирает компьютер.");
            Console.WriteLine("\t\t2. Играть вторую партию с игроком AA");
            Console.WriteLine("\t\t3. Играть вторую партию с игроком BB\n");
            Console.WriteLine("\tВнимание! Игрока 2 в вариантах 2 и 3 для первой партии всегда выбирает компьютер.\n");
            Console.WriteLine("\tУ вас и Игрока 2 есть две кнопки на экране монитора - 'ноль' и 'единица'. Кнопки появятся на экране после того" +
                                "как Вы будете готовы к началу игры - нажмёте на кнопку 'Начать игру' на экране.\n");
            Console.WriteLine("\tВы начинаете каждый ход в игре. Для этого Вы должны принять решение и нажать выбранную кнопку - '0' или '1'.\n");
            Console.WriteLine("\tИгрок 2 ответит на ваше действие нажатием выбранной им одной из двух кнопок\n");
            Console.WriteLine("\tРезультат шага (выигрыш на шаге!) в игре будет следующим:");
            Console.WriteLine("\t\t1. Если Вы и Игрок 2 нажали кнопку '1', то каждый получит по 100 рублей.");
            Console.WriteLine("\t\t2. Если Вы и Игрок 2 нажали кнопку '0', то никто из вас не получит ничего.");
            Console.WriteLine("\t\t3. Если Вы нажмёте кнопку '0', а Игрок 2 - кнопку '1', то Вы получите 500 рублей, а Игрок 2 не получит ничего.");
            Console.WriteLine("\t\t4. Если Вы нажмёте кнопку '1', а Игрок 2 - кнопку '0', то Игрок 2 получит 500 рублей, а Вы ничего не получите.\n");
            Console.WriteLine("\tТекущий результат - Ваш Игрока 2 - в каждой игре Вы будете видеть на экране.\n");
            Console.WriteLine("\tВнимание! После окончания каждой партии зафиксируйте Ваш выигрыш и выигрыш Игрока 2 в отчёте.\n");
            Console.WriteLine("\tПосле окончания игры напишите самоотчёт по игре в целом, в котором дайте характеристику" +
                                "Вашей игре и игре противника - Игрока 2.\n");
            Console.WriteLine("\tЕсли Вы готовы начать игру, нажмите кнопку 'Начать игру'.");

            Console.ReadKey();
        }
    }
}
