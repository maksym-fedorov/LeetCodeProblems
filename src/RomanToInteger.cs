namespace LeetCode.Problems
{
    internal sealed class RomanToInteger
    {
        public static int Run(string s)
        {
            int result = 0;

            for (int i = 0; i < s.Length; i++)
            {
                var s1 = s[i];
                var s2 = i + 1 < s.Length ? s[i + 1] : ' ';

                switch (s1)
                {
                    case 'I':
                        {
                            switch (s2)
                            {
                                case 'V':
                                    {
                                        result += 4;
                                        i++;
                                        continue;
                                    }
                                case 'X':
                                    {
                                        result += 9;
                                        i++;
                                        continue;
                                    }
                                default:
                                    {
                                        result += 1;
                                    }
                                    break;
                            }
                        }
                        break;
                    case 'V':
                        {
                            result += 5;
                        }
                        break;
                    case 'X':
                        {
                            switch (s2)
                            {
                                case 'L':
                                    {
                                        result += 40;
                                        i++;
                                        continue;
                                    }
                                case 'C':
                                    {
                                        result += 90;
                                        i++;
                                        continue;
                                    }
                                default:
                                    {
                                        result += 10;
                                    }
                                    break;
                            }
                        }
                        break;
                    case 'L':
                        {
                            result += 50;
                        }
                        break;
                    case 'C':
                        {
                            switch (s2)
                            {
                                case 'D':
                                    {
                                        result += 400;
                                        i++;
                                        continue;
                                    }
                                case 'M':
                                    {
                                        result += 900;
                                        i++;
                                        continue;
                                    }
                                default:
                                    {
                                        result += 100;
                                    }
                                    break;
                            }
                        }
                        break;
                    case 'D':
                        {
                            result += 500;
                        }
                        break;
                    case 'M':
                        {
                            result += 1000;
                        }
                        break;
                    default:
                        break;
                }
            }

            return result;
        }
    }
}