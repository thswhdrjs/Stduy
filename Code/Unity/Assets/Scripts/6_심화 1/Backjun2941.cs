using UnityEngine;

public class Backjun2941 : MonoBehaviour
{
    private void Start()
    {
        Algorithm("ljes=njak");
        Algorithm("ddz=z=");
        Algorithm("nljj");
        Algorithm("c=c=");
        Algorithm("dz=ak");
    }

    private void Algorithm(string s)
    {
        if (!(0 < s.Length && s.Length <= 100))
            return;

        int count = 0;

        for (int i = 0; i < s.Length; i++)
        {
            switch (s[i])
            {
                case 'c':
                    {
                        if (s[i + 1] == '=' || s[i + 1] == '-')
                            i++;

                        break;
                    }
                case 'd':
                    {
                        if (s[i + 1] == '-')
                            i++;
                        else if (s[i + 1] == 'z' && s[i + 2] == '=')
                            i += 2;

                        break;
                    }
                case 'l':
                    {
                        if (s[i + 1] == 'j')
                            i++;

                        break;
                    }
                case 'n':
                    {
                        if (s[i + 1] == 'j')
                            i++;

                        break;
                    }
                case 's':
                    {
                        if (s[i + 1] == '=')
                            i++;

                        break;
                    }
                case 'z':
                    {
                        if (s[i + 1] == '=')
                            i++;

                        break;
                    }
            }

            count++;
        }

        Debug.Log(count);
    }
}
