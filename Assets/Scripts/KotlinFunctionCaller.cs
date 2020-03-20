using UnityEngine;

public class KotlinFunctionCaller : MonoBehaviour
{
    public void SamplePackageFunction()
    {
        using (var javaClass = new AndroidJavaClass("com.redfreshet.samplelibrary.SampleKotlinKt"))
        {
            javaClass.CallStatic("SamplePackageFunction");
        }
    }

    public void SampleObjectFunction()
    {
        using (var javaObj = new AndroidJavaObject("com.redfreshet.samplelibrary.SampleObject"))
        {
            javaObj.Call("SampleObjectFunction");
        }
    }

    public void SampleJvmCompanionObjectFunction()
    {
        using (var javaObj = new AndroidJavaObject("com.redfreshet.samplelibrary.SampleKotlin"))
        {
            javaObj.CallStatic("SampleJvmCompanionObjectFunction");
        }
    }

    public void SampleClassFunction()
    {
        using (var javaObj = new AndroidJavaObject("com.redfreshet.samplelibrary.SampleKotlin"))
        {
            javaObj.Call("SampleClassFunction");
        }
    }
}