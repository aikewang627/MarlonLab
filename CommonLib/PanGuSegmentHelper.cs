using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PanGu;

namespace MarlonLab.CommonLib
{
    /// <summary>
    /// 使用前，须在运行目录下添加PanGu.xml文件、Dict目录。
    /// </summary>
    public class PanGuSegmentHelper
    {
        private static Segment segment;

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
        public static List<string> SegmentToStringList(string text)
        {
            List<string> ret = new List<string>();
            if (segment == null)
            {
                PanGu.Segment.Init();
                segment = new Segment();
            }
            ICollection<WordInfo> words = segment.DoSegment(text);
            foreach (WordInfo word in words)
            {
                ret.Add(word.Word);
            }
            return ret;
        }

    }
}
