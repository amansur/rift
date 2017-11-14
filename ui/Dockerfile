FROM node:latest
COPY package.json /ui/
WORKDIR /ui
RUN ["npm", "install"]
ENTRYPOINT [ "npm", "start" ]