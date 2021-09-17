FROM node:14.17.3-alpine3.12 as build-step
WORKDIR /app
COPY package.json ./
RUN npm install
COPY . .

FROM build-step AS build-serve
EXPOSE 4200
CMD npm run start
