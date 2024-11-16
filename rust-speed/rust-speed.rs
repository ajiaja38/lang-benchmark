use std::time::Instant;

fn main() {
  let start_time = Instant::now();

  let input = 2_000_000;

  for i in 1..=input {
    println!("{}", i);
  }

  let duration = start_time.elapsed();

  println!("Result Time: {:.6} seconds", duration.as_secs_f64());
}