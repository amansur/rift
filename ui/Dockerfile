FROM node:latest
COPY ./package.json /ui/package.json
WORKDIR /ui
RUN ["npm", "install"]
ENTRYPOINT [ "npm", "start" ]