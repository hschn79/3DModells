var UnityJavascipt =
{
    // This object can hold variables for you.
    $JustAWebGLObject:
    {

    },

    SendToJavscript: function (dataJsonPtr)
    {
        // string paramters from unity get delivered to javascript as pointers.
        // So we get the actual string from the pointer.
        var dataJson = Pointer_stringify(dataJsonPtr);

        // Now convert the string to a javascript object.
        //var jsobject = JSON.parse(dataJson);

        // Now you have the jsObject, Vue can access it from here.
        // You can use Vue API from here too.

        // I'll just debug some variables.
        console.log(dataJson);
   
    },

};
autoAddDeps(UnityJavascipt , '$JustAWebGLObject');
mergeInto(LibraryManager.library, UnityJavascipt );