const f = (list) => {
  let sum = 0;
  const listLength = list.length
  for (let i = 0; i < listLength; i++) {
    const current = list[i]
    const next = i + 1 >= listLength ? list[0] : list[i + 1]
    if (current === next) {
      sum += next
    }
  }  
  return sum
}

// second solution
const f2sum = (arr) => {
  const arrCopy = arr.slice()
  if (arr.length) {
    return arrCopy.shift() + f2sum(arrCopy)
  }
  return 0
}

const f2 = (list) => {
  const listLength = list.length
  return f2sum(list.filter((el, i) => {
    return el === list[(i + 1 ) % listLength]
  }))
}
