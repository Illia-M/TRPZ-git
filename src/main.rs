
#![no_std]

#![feature(alloc_error_handler)]
#![feature(lang_items)]

// --------------------------------
// all this drama below wants to move out of here.
// maybe into a prelude.

extern crate alloc;
#[global_allocator]
static ALLOC: dotnet_allocator::MyAllocator = dotnet_allocator::MyAllocator {};
#[alloc_error_handler]
#[no_mangle]
fn alloc_error_handler(_layout: alloc::alloc::Layout) -> ! {
    //panic!("allocation error: {:?}", layout)
    loop {}
}

#[panic_handler]
fn panic(_info: &core::panic::PanicInfo) -> ! {
    loop {}
}
#[lang = "eh_personality"] extern fn eh_personality() {}
// --------------------------------

use ::dotnet::overloads_with_count::*;
use ::dotnet::overloads_prop::*;

#[no_mangle]
pub extern "C" fn main() {
    let s = "Hello World";
    // convert the Rust string (utf8) to a CLR string
    let s_clr = ::dotnet::System::Text::Encoding::UTF8().GetString_1(s.as_bytes());
    ::dotnet::System::Console::WriteLine_1(&s_clr);

    
    let s = "Anzhela Redchyts";
    // convert the Rust string (utf8) to a CLR string
    let s_clr = ::dotnet::System::Text::Encoding::UTF8().GetString_1(s.as_bytes());
    ::dotnet::System::Console::WriteLine_1(&s_clr);
}

