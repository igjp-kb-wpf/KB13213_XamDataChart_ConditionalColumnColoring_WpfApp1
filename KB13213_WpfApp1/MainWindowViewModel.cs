using KB13213_WpfApp1.Infrastructure;
using KB13213_WpfApp1.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KB13213_WpfApp1;
internal class MainWindowViewModel : ObservableObject
{
    private ObservableCollection<ScoreResult> _scoreResults;

    public ObservableCollection<ScoreResult> ScoreResults
    {
        get { return _scoreResults; }
        set { _scoreResults = value; OnPropertyChanged(); }
    }

    public MainWindowViewModel()
    {
        _scoreResults = new()
        {
            new() { Subject = "国語", Score = 70 },
            new() { Subject = "数学", Score = 90 },
            new() { Subject = "英語", Score = 83 },
            new() { Subject = "社会", Score = 40 },
            new() { Subject = "理科", Score = 85 },
        };
    }
}
