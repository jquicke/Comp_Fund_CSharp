// Instances of the CD class maintain the number of units sold
// and can describe something about its music certification:
//    1. No music certification
//    2. Gold
//    3. Platinum
//  Show that the same code can return three different results.
//  ToString has three examples of the Guarded Action pattern.
using System;

class CD
{
  private string artist;
  private string title;
  private int sales;

  // Construct a CD with the given title
  // The default state is that this CD has 0 copies sold.
  public CD(string initArtist, string initTitle)
  {
    artist = initArtist;
    title = initTitle;
    sales = 0;
  }

  // Update the state of this CD so it knows about any new sales.
  // unitsSold: CDs sold not already added to total record sales.
  public void RecordNewSales(int unitsSold)
  {
    sales += unitsSold;
  }

  // Provide access to the state of this CD to show 
  // unit sales and current music certification.
  // Returns the title, the sales, and a message.
  public override string ToString()
  {
    // Put a new line in each result with "\n" 
    string result = string.Format("{0} by {1}; sales are {2}\n",
                                  title, artist, sales);

    if (sales < 500000)
      result += " --No certification yet. Try more concerts.\n";

    if (sales >= 500000)
      result += " --Congrats, your music is certified gold.\n";

    if (sales >= 1000000)
      result += " --It's also gone platinum!";

    return result;
  }
} // end class CD