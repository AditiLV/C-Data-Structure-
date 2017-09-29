namespace Rextester
{
    public static class Program
    {
       public static void seprate(List<string> l)
        {  
            List<string> fulltime = new List<string>();
            List<int> resulttime = new List<int>();
            foreach (string listitem in l)
            {
                if(listitem.Length == 4)
                {
                    string hh = listitem[0].ToString() + listitem[1].ToString();
                string mm = listitem[2].ToString() + listitem[3].ToString();
                int h = Convert.ToInt32(hh);
                int m = Convert.ToInt32(mm);
                if ( h <= 23  && m <= 59)
                {
                
                    string finaltime = h.ToString() + m.ToString();
                    fulltime.Add(finaltime);
                }


                    
                }
            }
            if (fulltime.Count == 0)
            {
                Console.WriteLine("NOT POSSIBLE");
                return;
            }
            resulttime = fulltime.Select(s => int.Parse(s)).ToList();
            int r = resulttime.Max();
            Console.WriteLine(r);
        }

        public static IEnumerable<IEnumerable<T>> GetPermutations<T>(this IEnumerable<T> items)
        {
            if (items.Count() > 1)
            {
                return items.SelectMany(item => GetPermutations(items.Where(i => !i.Equals(item))),
                                        (item, permutation) => new[] { item }.Concat(permutation));
            }
            else
            {
                return new[] { items };
            }
        }

        public static void Main(string[] args)
        {
            List<String> asList1 = new List<String>();
            //Your code goes here
            var l = new List<int> { 7, 1, 5, 9 }; // change input here
            int cnt = 0;
            foreach (var item in l.GetPermutations())
            {
                 var a = item.ToArray();
                string temp = string.Join("", a);
                asList1.Add(temp);      
                cnt += 1;
            }
            try{
            seprate(asList1);
            }catch(Exception e){ Console.WriteLine(e.Message); }
        }
    }
}