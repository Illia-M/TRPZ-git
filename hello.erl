-module(helloworld).
-export([start/0]).

start() ->
    io:fwrite("Hello, world!\n"),
    io:fwrite("Ilya Vynohradov\n"),
    io:fwrite("Salikhov Michael\n"),
    io:fwrite("Yevhen Semeniak\n"),
    io:fwrite("Yaroslaw Angelovskiy\n").
