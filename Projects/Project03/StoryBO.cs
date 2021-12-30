using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project03
{
    class StoryBO
    {
        //Dictionary - collections
        public Dictionary<string, int> getGenreWiseCount(Story[] stories)
        {
            Dictionary<string, int> d = new Dictionary<string, int>();

            foreach (Story st in stories)
            {
                if (d.ContainsKey(st.Genre))
                {
                    d[st.Genre] = d[st.Genre] + 1;
                }
                else
                {
                    d.Add(st.Genre, 1);
                }
            }
            return d;
        }
    }
}
