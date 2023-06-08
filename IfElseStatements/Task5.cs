namespace IfStatements
{
    public static class Task5
    {
        public static int DoSomething1(bool b1, bool b2, bool b3, bool b4)
        {
            if (!b1 && !b2 && !b3 && !b4)
            {
                return 11;
            }
            else if (b1 && !b2 && !b3 && !b4)
            {
                return 0;
            }
            else if (!b1 && b2 && !b3 && !b4)
            {
                return 8;
            }
            else if (b1 && b2 && !b3 && !b4)
            {
                return 1;
            }
            else if (!b1 && !b2 && b3 && !b4)
            {
                return 5;
            }
            else if (b1 && !b2 && b3 && !b4)
            {
                return 2;
            }
            else if (!b1 && b2 && b3 && !b4)
            {
                return 4;
            }
            else if (b1 && b2 && b3 && !b4)
            {
                return 1;
            }
            else if (!b1 && !b2 && !b3 && b4)
            {
                return 10;
            }
            else if (b1 && !b2 && !b3 && b4)
            {
                return 3;
            }
            else if (!b1 && b2 && !b3 && b4)
            {
                return 9;
            }
            else if (b1 && b2 && !b3 && b4)
            {
                return 1;
            }
            else if (!b1 && !b2 && b3 && b4)
            {
                return 6;
            }
            else if (b1 && !b2 && b3 && b4)
            {
                return 2;
            }
            else if (!b1 && b2 && b3 && b4)
            {
                return 7;
            }
            else if (b1 && b2 && b3 && b4)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

        public static int DoSomething2(bool b1, bool b2, bool b3, bool b4)
        {
            int result;

            if (b1 && b2)
            {
                result = 1;
            }
            else if (b1 && b3)
            {
                result = 2;
            }
            else if (b1 && b4)
            {
                result = 3;
            }
            else if (!b1 && b3 && !b4 && b2)
            {
                result = 4;
            }
            else if (!b1 && b3 && !b4 && !b2)
            {
                result = 5;
            }
            else if (!b1 && b3 && b4 && !b2)
            {
                result = 6;
            }
            else if (!b1 && b3 && b4 && b2)
            {
                result = 7;
            }
            else if (!b1 && !b3 && b2 && !b4)
            {
                result = 8;
            }
            else if (!b1 && !b3 && b2 && b4)
            {
                result = 9;
            }
            else if (!b1 && !b3 && !b2 && b4)
            {
                result = 10;
            }
            else if (!b1 && !b3 && !b2 && !b4)
            {
                result = 11;
            }
            else
            {
                result = 0;
            }

            return result;
        }
    }
}
