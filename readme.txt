RUNNING THE APPLICATION

1. Open a new terminal in the root path of the project
2. Run the following commands
  -dotnet restore
  -dotnet run

CHANGING THE VALUES OF THE MATRIX AND WORD STREAM

Open and edit the following files located in the root path of the project:
-matrix.txt
-wordstream.txt

IMPORTANT: Do not rename the files, otherwise the application will crash. 

IMPORTANT: The contents of matrix.txt must be a perfect square, with matching column and row numbers. If the matrix does not follow this specification, an exception will be thrown.

RUNNING UNIT TESTS
1. Open a new terminal in the root path of the project
2. Run the following commands
  -dotnet test
