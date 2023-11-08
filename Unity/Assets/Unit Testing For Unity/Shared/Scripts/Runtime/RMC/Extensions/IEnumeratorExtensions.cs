using System.Collections;
using System.Threading.Tasks;

namespace RMC.UnitTesting.Shared.Extensions
{
    public static class IEnumeratorExtensions
    {
        public static IEnumerator AsCoroutine(this Task task)
        {
            while (!task.IsCompleted) yield return null;
            // if task is faulted, throws the exception
            task.GetAwaiter().GetResult();
        }
    }
}