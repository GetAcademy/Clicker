using System.Windows.Input;

namespace Clickerprogram;

internal class CommandSet
{
    private readonly ICommando[] _Array;

    public CommandSet(ClickerGame game)
    {
        _Array = new ICommando[]            
        {                                   
            new Disrupt(),                  
            new Oppgradering(game),             
            new Superoppgradering(game),        
            new GetPoints(game),                
        };                                  
    }
    public int RunCommand(char command)
    {
        Console.WriteLine(command);
        ICommando? ret_value = Find_object(command);
        if (ret_value != null)
        {
            ret_value.Run();
            return 0;
        }
        
        return 1;
    }

    private ICommando? Find_object(char command)
    {
        foreach (ICommando arr in _Array)
        {
            if (arr.Command == command) return arr;
        }

        return null;
    }
}