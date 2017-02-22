using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PanGu;

namespace MarlonLab.CommonLib
{
    public class PanGuSegmentHelper
    {
        public static Segment segment;

        public static ICollection<WordInfo> Segment(string text)
        {
            if (segment == null)
            {
                PanGu.Segment.Init();
                segment = new Segment();
            }
            ICollection<WordInfo> words = segment.DoSegment(text);
            return words;
        }
        public static List<string> SegmentReturnStringList(string text)
        {
            List<string> ret = new List<string>();
            if (segment == null)
            {
                PanGu.Segment.Init();
                segment = new Segment();
            }
            ICollection<WordInfo> words = segment.DoSegment(text);
            foreach (WordInfo word in words )
            {
                ret.Add(word.Word);
            }
            return ret;
        }

    }
}
