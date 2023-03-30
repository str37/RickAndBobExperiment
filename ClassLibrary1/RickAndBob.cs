namespace RickAndBobLib
{

    public interface IRickAndBob
    {
        List<string> GetRickAndBobifiedList(int listLength);

    }
    public class RickAndBob : IRickAndBob
    {

        public List<string>  GetRickAndBobifiedList(int listLength)
        {
            List<string> l = new List<string>();

            const int rickyNumber = 3;
            const int bobbyNumber = 5;

            for (int i = 1; i <= 100; i++)
            {
                if (i < rickyNumber)
                {
                    l.Add(i.ToString());
                }
                else
                {

                    var ricky = i % rickyNumber;
                    var bobby = i % bobbyNumber;


                    string currentLine = string.Empty; 
                    if (ricky == 0 || bobby == 0)
                    {
                        
                        if (ricky == 0)
                        {
                            currentLine += "Ricky ";
                        }
                        if (bobby == 0)
                        {
                            currentLine += "Bobby ";
                        }
                        l.Add(currentLine);
                    }
                    else
                    {
                        l.Add(i.ToString());
                    }
                }

            }
            return l;
        }

    }
}