namespace Interpreter.Registrars
{
    public class BasicRecorder
    {
        public static void RegisterTo(ICommandRecorder commandRecorder)
        {
            commandRecorder.Commands["var"] = (args, vm) => { vm.Memory[args[0]] = default; };
            commandRecorder.Commands["mov"] = (args, vm) => { vm.Memory[args[0]] = double.Parse(args[1]); };
            commandRecorder.Commands["add"] = (args, vm) => { vm.Memory[args[0]] += double.Parse(args[1]); };
            commandRecorder.Commands["sub"] = (args, vm) => { vm.Memory[args[0]] -= double.Parse(args[1]); };
            commandRecorder.Commands["mul"] = (args, vm) => { vm.Memory[args[0]] *= double.Parse(args[1]); };
            commandRecorder.Commands["div"] = (args, vm) => { vm.Memory[args[0]] /= double.Parse(args[1]); };
        }
    }
}