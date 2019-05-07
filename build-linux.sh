git clone https://github.com/CREDITSCOM/CS-API
thrift -gen csharp -out . ./CS-API/general.thrift
thrift -gen csharp -out . ./CS-API/api.thrift
dotnet add package apache-thrift-netcore --version 0.9.3.2
dotnet add package SimpleBase --version 1.8.0
