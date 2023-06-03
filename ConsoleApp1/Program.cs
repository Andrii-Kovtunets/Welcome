﻿using System;
using System.Threading;

class MessagePrinter
{
    static void Main(string[] args)
    {
        int[] message = {
            32, 83, 111, 46, 46, 46, 10, 32, 89, 111, 117, 32, 99, 114, 97, 99, 107, 101, 100, 32, 116, 104, 97, 116, 32, 99,
            111, 100, 101, 46, 10, 32, 67, 111, 110, 103, 114, 97, 116, 117, 108, 97, 116, 105, 111, 110, 115, 33, 10, 32, 84,
            104, 105, 115, 32, 109, 101, 97, 110, 115, 32, 116, 104, 97, 116, 32, 121, 111, 117, 32, 114, 101, 97, 108,
            108, 121, 32, 108, 111, 118, 101, 32, 99, 111, 100, 105, 110, 103, 46, 10, 32, 73, 110, 32, 116, 104, 97, 116,
            32, 99, 97, 115, 101, 44, 32, 73, 32, 97, 109, 32, 118, 101, 114, 121, 32, 103, 108, 97, 100, 32, 116, 111,
            32, 119, 101, 108, 99, 111, 109, 101, 32, 121, 111, 117, 32, 116, 111, 32, 111, 117, 114, 32, 99, 108, 97,
            115, 115, 33, 10, 32, 40, 65, 110, 100, 32, 98, 121, 32, 116, 104, 101, 32, 119, 97, 121, 44, 32, 121, 111, 117, 32,
            99, 97, 110, 32, 117, 115, 101, 32, 105, 116, 32, 119, 104, 101, 110, 101, 118, 101, 114, 32, 121, 111, 117,
            32, 119, 97, 110, 116, 41, 10, 32, 73, 32, 104, 111, 112, 101, 32, 121, 111, 117, 32, 119, 105, 108, 108, 32, 100,
            111, 32, 121, 111, 117, 114, 32, 98, 101, 115, 116, 32, 116, 111, 32, 108, 101, 97, 114, 110, 32, 97, 32, 108,
            111, 116, 32, 104, 101, 114, 101, 32, 10, 32, 115, 111, 32, 116, 104, 97, 116, 32, 121, 111, 117, 32, 99, 97, 110, 32,
            98, 101, 99, 111, 109, 101, 32, 97, 32, 103, 114, 101, 97, 116, 32, 112, 114, 111, 103, 114, 97, 109, 109, 101,
            114, 32, 111, 110, 101, 32, 100, 97, 121, 46, 10, 32, 71, 111, 111, 100, 32, 108, 117, 99, 107, 32, 58, 41
        };

        int counter = 0;

        foreach (int part in message)
        {
            if (part == 71)
            {
                Console.Write("\n ");
            }

            if (part == 10)
            {
                if (counter != 6)
                {
                    Thread.Sleep(1000);
                }
                counter++;
            }
            else
            {
                Thread.Sleep(50);
            }

            Console.Write((char)part);
        }

        Console.ReadKey();
    }
}


//You can download this code from GitHub using this link:
//github.com/Andrii-Kovtunets/Welcome