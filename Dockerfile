# dotnet capped at 6 since fake cli doesn't support dotnet 7
FROM mcr.microsoft.com/devcontainers/dotnet:6.0-bullseye

ARG USER='vscode'

ENV WORKDIR="/app"

COPY --chown=${USER}:${USER} docker-entrypoint.sh /usr/bin/

RUN chmod +x /usr/bin/docker-entrypoint.sh

ENTRYPOINT [ "docker-entrypoint.sh" ]

COPY --chown=${USER}:${USER} . ${WORKDIR}