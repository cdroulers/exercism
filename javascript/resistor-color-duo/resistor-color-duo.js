export const value = colors =>
  Number(colors.map(x => COLORS.indexOf(x)).join(""));

export const COLORS = [
  "black",
  "brown",
  "red",
  "orange",
  "yellow",
  "green",
  "blue",
  "violet",
  "grey",
  "white"
];
