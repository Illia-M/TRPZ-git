-module(helloworld).
-export([start/0]).

start() ->
    io:fwrite("Hello, world!\n"),
    io:fwrite("Ilya Vynohradov\n"),
    io:fwrite("Yevhen Semeniak\n").