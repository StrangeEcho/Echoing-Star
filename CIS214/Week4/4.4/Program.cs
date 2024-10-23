/*****
 * name: Ruben Thomas
 * date: 6.2.2024
 * assignment: CIS214 Week 4 GP - The Finally Block
 *
 * Main application (program) class.
 * In this application we will demonstate the use of exception handling
 * with a finally block
 */

using System;

public class FinallyDemo
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ruben Thomas - Week 4 GP - The Finally Block");

        try
        {
            ThrowException();
        }
        catch (Exception e)
        {
            Console.WriteLine("Exception handled in main. Message: " + e.Message);
        }

        DoesNotThrowException();
    }

    public static void ThrowException()
    {
        try
        {
            Console.WriteLine("\nMethod ThrowException");
            throw new Exception("Exception thrown in ThrowException");
        }
        catch
        {
            Console.WriteLine("Exception handled in method ThrowException");
        }
        finally
        {
            Console.WriteLine("Finally executed in ThrowException");
        }
    }

    public static void DoesNotThrowException()
    {
        try
        {
            Console.WriteLine("\nMethod DoesNotThrowException");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
        finally
        {
            Console.WriteLine("Finally executed in DoesNotThrowException");
        }
    }
}