FROM mcr.microsoft.com/devcontainers/dotnet:8.0-bookworm-slim

ARG USER='vscode'
ARG NODE_VERSION="lts/*"

ENV WORKDIR="/app" \
    DEBIAN_FRONTEND=noninteractive

WORKDIR ${WORKDIR}

RUN if [ "${NODE_VERSION}" != "none" ]; then su vscode -c "umask 0002 && . /usr/local/share/nvm/nvm.sh && nvm install ${NODE_VERSION} 2>&1"; fi

RUN su vscode -c "source /usr/local/share/nvm/nvm.sh && npm install -g yarn" 2>&1

COPY --chown=${USER}:${USER} docker-entrypoint.sh /usr/local/bin/docker-entrypoint.sh

RUN chmod +x /usr/local/bin/docker-entrypoint.sh

COPY --chown=${USER}:${USER} package.json yarn.lock ${WORKDIR}

RUN yarn install

COPY --chown=${USER}:${USER} . ${WORKDIR}

ENTRYPOINT [ "docker-entrypoint.sh" ]

RUN dotnet tool restore && \
    dotnet paket restore && \
    yarn

CMD ["yarn", "start"]