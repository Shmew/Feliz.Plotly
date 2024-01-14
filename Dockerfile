FROM mcr.microsoft.com/devcontainers/dotnet:8.0-bookworm

ARG USER='vscode'

ENV WORKDIR="/app"

COPY --chown=${USER}:${USER} docker-entrypoint.sh /usr/bin/

RUN chmod +x /usr/bin/docker-entrypoint.sh

ENTRYPOINT [ "docker-entrypoint.sh" ]

COPY --chown=${USER}:${USER} . ${WORKDIR}

WORKDIR ${WORKDIR}

RUN dotnet tool restore && \
    dotnet paket restore