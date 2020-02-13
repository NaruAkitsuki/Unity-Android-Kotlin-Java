package com.redfreshet.samplelibrary;

import android.util.Log

fun SamplePackageFunction() {
    Log.d("TEST", "SamplePackageFunction")
}

object SampleObject {
    fun SampleObjectFunction() {
        Log.d("TEST", "SampleObjectFunction")
    }
}

class SampleKotlin {
    companion object {
        fun SampleCompanionObjectFunction() {
            Log.d("TEST", "SampleCompanionObjectFunction")
        }
    }

    fun SampleClassFunction() {
        Log.d("TEST", "SampleClassFunction")
    }
}