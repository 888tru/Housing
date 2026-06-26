using System.IO.IsolatedStorage;

public class FlagParser
{
    public static Dictionary<string,string> FlagParse(string[] args)
    {
        Dictionary<string, string> dict = new Dictionary<string, string>();
        int i = 0;
        while (i < args.Length)
            
        {
            string token = args[i];
            if (!isFlag(token)) {
                i++;
                continue;
            }
            string key = (token.Substring(1).ToString()).ToLower();

            if(i+1 >= args.Length || isFlag(args[i + 1])){
                throw new ArgumentException("flaq -" + key + " entered without value");
             
            }
            var value = args[i + 1];
            dict[key] = value;
            i += 2;

        }
        return dict;
    }

    private static bool isFlag(string token)
    {

        if (token.Length < 2) return false;
        if (token[0] != '-') return false;
        if (char.IsLetter(token[1])) return true;
        else return false;
    }

    public static string GetRequared(string flag, Dictionary<string, string> dict)
    {
        if (dict.TryGetValue(flag, out string value))
        {
            return value;
        }
        else throw new ArgumentException("There is now correct flag");

    }
    
}