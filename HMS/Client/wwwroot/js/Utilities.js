﻿function my_function(message) {
    console.log("from utilities" + message);
}
function dotnetStaticInvocation() {
    DotNet.invokeMethodAsync("HMS.Client", "GetCurrentCount")
    .then(result => {
        console.log("count from javascript" + result);
    });
}
function dotnetInstanceInvocation(dotnetHelper) {
    dotnetHelper.invokeMethodAsync("IncrementCount");
}