﻿using Interf3;

Smartphone smartphone = new Smartphone("iPhone 13", "Apple", 999.99m, "iOS");
Laptop laptop = new Laptop("Dell XPS 13", "Dell", 1299.99m, 16);

// Test IProduct interface
Console.WriteLine("Displaying Information:");
smartphone.DisplayInfo();
Console.WriteLine();
laptop.DisplayInfo();
Console.WriteLine();

// Test IShoppable interface
Console.WriteLine("Adding to Cart:");
smartphone.AddToCart();
laptop.AddToCart();
