using KB13213_WpfApp1.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KB13213_WpfApp1.Model;
internal class ScoreResult : ObservableObject
{
    private String _subject = "";
    public String Subject
    {
        get { return _subject; }
        set { _subject = value; OnPropertyChanged(); }
    }

    private int _score;
    public int Score
    {
        get { return _score; }
        set { _score = value; OnPropertyChanged(); }
    }

    public ScoreResult()
    {
    }
}
