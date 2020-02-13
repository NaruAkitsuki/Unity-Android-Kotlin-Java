package com.redfreshet.samplelibrary;

import android.util.Log;

public class SampleJava {
    public static void sampleStaticMethod() {
        Log.d("TEST", "sampleStaticMethod");
    }

    public void sampleInstanceMethod() {
        Log.d("TEST", "sampleInstanceMethod");
    }

    public static class sampleInnerClass {
        public static void sampleStaticMethodInner() {
            Log.d("TEST", "sampleStaticMethodInner");
        }

        public void sampleInstanceMethodInner() {
            Log.d("TEST", "sampleInstanceMethodInner");
        }
    }
}