// import { create, createReportList, clear } from "./modules/canvas.js";
import * as Canvas from "./modules/canvas.js";
import randomSquare, {
  draw,
  reportArea,
  reportPerimeter,
} from "./modules/square.js";
const createSquareBtn = document.querySelector("create-square-btn");
const clearBtn = document.querySelector("clear-btn");

let myCanvas = create("my-canvas", document.body, 480, 320);
let reportList = createReportList(myCanvas.id);

let square1 = draw(myCanvas.ctx, 50, 50, 100, "blue");
reportArea(square1.length, reportList);
reportPerimeter(square1.length, reportList);

let square2 = randomSquare(myCanvas.ctx);
clearBtn.addEventListener("click", () => {
  Canvas.clear(myCanvas.ctx);
});
