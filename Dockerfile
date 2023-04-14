FROM mcr.microsoft.com/dotnet/sdk:7.0
WORKDIR /usr/robo

COPY . ./

RUN dotnet restore
RUN dotnet publish -c Release -o out
RUN ls
RUN pwsh ./out/playwright.ps1 install firefox --with-deps
EXPOSE 5000
CMD ./out/RoboDeApostas