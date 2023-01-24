using System;
using System.Globalization;
using System.Threading;
public class EuroSymbolSample
{
    public static void Main()
    {
        int i = 100;
        // Set the CurrentCulture to French in France.
        Thread.CurrentThread.CurrentCulture = new CultureInfo("fr-FR");
        // Display i formatted as default currency for the CurrentCulture.
        // On a version of Windows prior to Windows XP, where the user
        // has not changed the default currency to euro through
        // Control Panel, this will default to "F".
        Console.WriteLine(i.ToString("c"));
        // Set the CurrentCulture to French in France, using the
        // CultureInfo constructor that takes a useUserOverride parameter.
        // Set the useUserOverride value to false.
        Thread.CurrentThread.CurrentCulture = new CultureInfo("fr-FR", false);
        // Display formatted as default currency for the CurrentCulture.
        // On a version of Windows prior to Windows XP, this will override
        // an incorrect default setting of "F" and display the euro symbol.
        Console.WriteLine(i.ToString("c"));
    }
}