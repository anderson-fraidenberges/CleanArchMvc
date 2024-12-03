
//// See https://aka.ms/new-console-template for more information
//Either<string, double> Divide(double a, double b) {
//    if (b == 0) {
//        return Either<string, double>.Left("Error: Not is possible divide to zero");
//    }

//    return Either<string, double>.Right(a/b);
//}

//var result = Divide(15,2);

//string message  = result.Match(onLeft: error => $"Erro {error}",
//                  onRight: success => $"Resultado: {success}"
//);

//Console.WriteLine(message);

//var resultError = Divide(10,4);

//string errorMessage = resultError.Match(onLeft : error => $"Erro: {error}",
//                      onRight: success => $"Resultado: {success}"
//);

//Console.WriteLine(errorMessage);
