using UnityEngine;

public class JavaFunctionCaller : MonoBehaviour
{
    public void SampleStaticMethod()
    {
        using (var javaClass = new AndroidJavaClass("com.redfreshet.samplelibrary.SampleJava"))
        {
            javaClass.CallStatic("sampleStaticMethod");
        }
    }

    public void SampleInstanceMethod()
    {
        using (var javaObj = new AndroidJavaObject("com.redfreshet.samplelibrary.SampleJava"))
        {
            javaObj.Call("sampleInstanceMethod");
        }
    }
}