using System;

public class Reference
{
    private string _book;
    private int _chapter;

    private int _verse;

    private int _ending;

 public Reference (string book, int chapter, int verse)
 {
   this._book = book;
   this._chapter = chapter;
   this._verse = verse;
   this._ending = this._verse;
 }

 public Reference ( string book, int chapter, int verse,int ending)
  {
    this._book = book;
    this._chapter = chapter;
    this._verse = verse;
    this._ending = ending;
  }

  public string GetDisplayText() 
  {
    if (_verse == _ending)

     return _book + " " + _chapter + ":" + _verse;

     else
       return _book + " " + _chapter + ":" + _verse + "-" + _ending;

  }

}
    
