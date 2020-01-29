public static class Kata
{
  // return masked string
  public static string Maskify(string cc)
  {
    if (cc.Length > 4)
        {
            for (int i=0;i<(cc.Length-4);i++)
            { 
                cc = cc.Remove(i,1).Insert(i,"#");
            }                
            return cc;
        }
    else return cc;
  }
}
