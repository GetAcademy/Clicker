using System.Windows.Input;

namespace Clickerprogram;

internal class CommandSet
{
    private ICommando[] _Array;

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
    public int RunCommand(string command)
    {
        ICommando? ret_value = findobj(command);
        if (ret_value != null)
        {
            ret_value.Run();
            return 0;
        }
        
        return 1;
    }

    private ICommando? findobj(string command)
    {
        foreach (ICommando arr in _Array)
        {
            if(arr.Command != command) continue;
            return arr;
        }

        return null;
    }
}