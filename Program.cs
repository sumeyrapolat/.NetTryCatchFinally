    // See https://aka.ms/new-console-template for more information

    //Try catch ile hataya neden olabilecek bir süreci yönetebiliyoruz

    try {
        Console.WriteLine("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Your number: " + number);

    }
    catch (Exception e)
    {
        Console.WriteLine("Error: " + e.Message.ToString());
    }
    finally {
        Console.WriteLine("Process Done.");
    }


    try
    {
    //int num = int.Parse(null);
    //int input = int.Parse("Hello World!");
    int number = int.Parse("-2563147854963");

    }
    catch (ArgumentException e)
    {
        Console.WriteLine("You entered null value.");
        Console.WriteLine("Error: " + e.Message.ToString());
    }
    catch (FormatException e )
    {
        Console.WriteLine("Format is not appropriate.");
        Console.WriteLine("Error: "+ e.Message.ToString());
    }
    catch (OverflowException e)
    {
        Console.WriteLine("Error: " +e.Message.ToString());
    }
    finally
    {
        Console.WriteLine("Process is done again.");
    }
