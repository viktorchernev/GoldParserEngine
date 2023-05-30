

program test;

const
  PI = 3.1415;

var
  a, b: real;

procedure hello(s: string; n: real);
begin
  writeln(s);
end;

begin
  a := PI;
  b := a * 10;
  hello('Hello World!', b);
end.
