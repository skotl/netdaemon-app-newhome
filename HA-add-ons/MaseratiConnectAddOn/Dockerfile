ARG BUILD_FROM
FROM $BUILD_FROM

RUN apk update
RUN apk add bash libstdc++ libgcc icu glib nss libxcb libatk-1.0 libatk-bridge-2.0
RUN apk add cups-libs libdrm expat libxkbcommon libxcomposite libxdamage libxfixes libxrandr
RUN apk add mesa-gbm pango cairo alsa-lib gcompat sudo chromium-chromedriver

RUN adduser -D -h /dotnet dotnet

WORKDIR /dotnet

RUN wget https://dot.net/v1/dotnet-install.sh -O dotnet-install.sh
RUN chmod 777 dotnet-install.sh
RUN sudo -u dotnet ./dotnet-install.sh --channel 8.0

COPY app/ /dotnet

RUN chmod 777 /dotnet/selenium-manager/linux/selenium-manager
RUN sudo -u dotnet /dotnet/selenium-manager/linux/selenium-manager --browser chrome
RUN echo /dotnet/.dotnet/dotnet Kwolo.MaseratiConnect.TestHarness.dll >/dotnet/go && chmod 700 /dotnet/go
RUN chown -R dotnet /dotnet

COPY run.sh /
RUN chmod 700 /run.sh
RUN ls -la /
CMD [ "/run.sh" ]



