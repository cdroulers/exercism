export function value(colors) {
  return parseInt(colors.map(x => COLORS.indexOf(x).toString()).join(""));
};

export const COLORS = ["black","brown","red","orange","yellow","green","blue","violet","grey","white"];