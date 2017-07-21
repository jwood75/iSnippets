using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iSnippets.Models
{
    public class Snippet
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string SnippetText { get; set; }
        public string Language { get; set; }
    }
}