using System.Reflection;

namespace UnityEngine.MaterialGraph
{
    [Title("Math/Advanced/Length")]
    public class LengthNode : CodeFunctionNode
    {
        public LengthNode()
        {
            name = "Length";
        }

        protected override MethodInfo GetFunctionToConvert()
        {
            return GetType().GetMethod("Unity_Length", BindingFlags.Static | BindingFlags.NonPublic);
        }

        static string Unity_Length(
            [Slot(0, Binding.None)] DynamicDimensionVector argument,
            [Slot(1, Binding.None)] out DynamicDimensionVector result)
        {
            return
                @"
{
    result = length(argument);
}
";
        }
    }
}